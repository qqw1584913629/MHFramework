using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
public enum UIWindowType
{
    Normal,    // 普通主界面
    Fixed,     // 固定窗口
    PopUp,     // 弹出窗口
    Other,      //其他窗口
}
public class UIManager
{
    private static UIManager _instance;


    private Dictionary<WindowID, string> windowConfigDict = new Dictionary<WindowID, string>();
    private Dictionary<string, WindowID> windowIdDict = new Dictionary<string, WindowID>();
    private Dictionary<WindowID, BasePanel> openWindowDict = new Dictionary<WindowID, BasePanel>();
    private Dictionary<WindowID, BasePanel> prefabWindowDict = new Dictionary<WindowID, BasePanel>();
    public readonly Dictionary<WindowID, IAUIEventHandler> UIEventHandlers = new Dictionary<WindowID, IAUIEventHandler>();

    private Stack<BasePanel> openWindowStack = new Stack<BasePanel>();
    
    
    
    public Transform NormalRoot{ get; set; }
    public Transform FixedRoot{ get; set; }
    public Transform PopUpRoot{ get; set; }
    public Transform OtherRoot{ get; set; }
    
    private Transform _uiRoot;
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new UIManager();
            return _instance;
        }
    }

    public Transform UIRoot
    {
        get
        {
            if (_uiRoot == null)
                _uiRoot = GameObject.Find("Root").transform;
            return _uiRoot;
        }
    }
    private UIManager()
    {
        NormalRoot = GameObject.Find("Global/Root/Normal").transform;
        FixedRoot = GameObject.Find("Global/Root/Fixed").transform;
        PopUpRoot = GameObject.Find("Global/Root/PopUp").transform;
        OtherRoot = GameObject.Find("Global/Root/Other").transform;
        var assembly = typeof(UIManager).Assembly;
        foreach (Type type in assembly.GetTypes())
        {
            object[] objects = type.GetCustomAttributes(typeof(AUIEventAttribute), true);
            if (objects.Length == 0)
                continue;
            AUIEventAttribute attr = objects[0] as AUIEventAttribute;
            UIEventHandlers.Add(attr.WindowID, Activator.CreateInstance(type) as IAUIEventHandler);
        }
        foreach (WindowID windowID in Enum.GetValues(typeof(WindowID)))
        {
            string dlgName = "Dlg" + windowID.ToString().Split('_')[1];
            windowConfigDict.Add(windowID , dlgName);
            windowIdDict.Add(dlgName, windowID );
        }
    }
    public T GetUILogic<T>(WindowID id) where T : BasePanel
    {
        //检查缓存
        if (!windowConfigDict.TryGetValue(id, out string name))
        {
            Debug.LogError("界面不存在！！！");
            return null;
        }
        //检查是否已经打开
        if (!openWindowDict.TryGetValue(id, out BasePanel basePanel))
        {
            Debug.LogError("界面还未打开！！！");
            return null;
        }
        return basePanel.uiLogic as T;
    }
   public void ShowWindow(WindowID id, object context = null)
    {
        //检查缓存
        if (!windowConfigDict.TryGetValue(id, out string name))
        {
            Debug.LogError("界面不存在！！！");
            return;
        }
        //检查是否已经打开
        if (openWindowDict.TryGetValue(id, out BasePanel basePanel))
        {
            Debug.LogError("界面已经打开！！！");
            return;
        }
        //检查缓存
        if (!prefabWindowDict.TryGetValue(id, out basePanel))
        {
            var obj = ResourceHelper.LoadGameObjectSync<GameObject>(name);
            //打开界面
            var panelObject = GameObject.Instantiate(obj, UIRoot, false);
            //如果界面没有在缓存中则实例化一个
            basePanel = Activator.CreateInstance(typeof(BasePanel)) as BasePanel;
            if (basePanel != null)
            {
                basePanel.obj = panelObject;
                GetUIEventHandler(id).OnInitWindowCoreData(basePanel);
                prefabWindowDict.Add(id, basePanel);
                SetRoot(basePanel, GetTargetRoot(basePanel.windowType));
                openWindowDict.Add(id, basePanel);
                openWindowStack.Push(basePanel);
                basePanel.obj.SetActive(true);
                GetUIEventHandler(id).OnRegisterUIEvent(basePanel);
                GetUIEventHandler(id).OnShowWindow(basePanel, context);
            }
            return;
        }
        //如果有
        openWindowDict.Add(id, basePanel);
        basePanel.obj.SetActive(true);
        GetUIEventHandler(id).OnShowWindow(basePanel, context);
        openWindowStack.Push(basePanel);
    }
   public bool CloseWindow(WindowID id)
    {
        //检查是否打开
        if (!openWindowDict.TryGetValue(id, out BasePanel basePanel))
        {
            Debug.LogError("界面未打开，关闭失败");
            return false;
        }
        UnityEngine.Object.Destroy(basePanel.obj);
        GetUIEventHandler(id).BeforeUnload(basePanel);
        //从字典中移除
        openWindowDict.Remove(id);
        prefabWindowDict.Remove(id);
        //弹出栈
        openWindowStack.Pop();
        return true;
    }
   public bool HideWindow(WindowID id)
    {
        // 检查是否打开
        if (!openWindowDict.TryGetValue(id, out BasePanel basePanel))
        {
            Debug.LogError("界面未打开，关闭失败");
            return false;
        }
        basePanel.obj.SetActive(false);
        GetUIEventHandler(id).OnHideWindow(basePanel);
        // 从字典中移除
        openWindowDict.Remove(id);
        // 从堆栈中弹出
        openWindowStack.Pop();
        return true;
    }
   public Transform GetTargetRoot(UIWindowType type)
   {
       switch (type)
       {
           case UIWindowType.Normal:
               return NormalRoot;
           case UIWindowType.Fixed:
               return FixedRoot;
           case UIWindowType.PopUp:
               return PopUpRoot;
           case UIWindowType.Other:
               return OtherRoot;
           default:
               Debug.LogError("uiroot type is error: " + type.ToString());
               return null;
       }
   }
   public void SetRoot(BasePanel basePanel, Transform rootTransform)
   {
       Transform transform;
       (transform = basePanel.obj.transform).SetParent(rootTransform);
       transform.localScale = Vector3.one;
   }
   public IAUIEventHandler GetUIEventHandler(WindowID windowID)
   {
       if (UIEventHandlers.TryGetValue(windowID, out IAUIEventHandler handler))
       {
           return handler;
       }
       return null;
   }
}
public static class MHUIModelViewHelper
{
    public static void AddUIScrollItems<K,T>(this K self, ref Dictionary<int, T> dictionary, int count) where K : IUILogic  
        where T : IUIScrollItem
    {
        if (dictionary == null)
        {
            dictionary = new Dictionary<int, T>();
        }
            
        if (count <= 0)
        {
            dictionary.Clear();
            return;
        }
            
        // foreach (var item in dictionary)
        // {
        //     item.Value.Dispose();
        // }
        dictionary.Clear();
        for (int i = 0; i < count; i++)
        {
            Type type = typeof (T);
            IUIScrollItem component = Activator.CreateInstance(type) as IUIScrollItem;
            T itemServer = (T)component;
            dictionary.Add(i , itemServer);
        }
    }
}

public interface IUILogic
{
    
}

public interface IUIScrollItem
{
}