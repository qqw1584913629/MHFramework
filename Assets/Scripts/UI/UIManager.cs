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
public interface IUIScrollItem
{
    
}public interface IUILogic
{
    
}
public class UIManager
{
    private static UIManager _instance;


    private Dictionary<string, string> windowConfigDict = new Dictionary<string, string>();
    private Dictionary<string, BasePanel> openWindowDict = new Dictionary<string, BasePanel>();
    private Dictionary<string, GameObject> prefabWindowDict = new Dictionary<string, GameObject>();
    private Stack<BasePanel> openWindowStack = new Stack<BasePanel>();
    
    
    
    public Transform NormalRoot{ get; set; }
    public Transform FixedRoot{ get; set; }
    public Transform PopUpRoot{ get; set; }
    public Transform OtherRoot{ get; set; }

    
    /// <summary>
    /// 这里会有错误 uimannager
    /// </summary>
    public void GetStackCount()
    {
        if (openWindowStack.Count > 0)
        {
            Debug.LogWarning(openWindowStack.Count);
            Debug.LogWarning(openWindowStack.Peek().GetType());
        }
    }
    
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
        InitWindowPathConfig();
        NormalRoot = GameObject.Find("Global/Root/Normal").transform;
        FixedRoot = GameObject.Find("Global/Root/Fixed").transform;
        PopUpRoot = GameObject.Find("Global/Root/PopUp").transform;
        OtherRoot = GameObject.Find("Global/Root/Other").transform;
    }
    private void InitWindowPathConfig()
    {
        // 获取WindowID类型
        Type type = typeof(WindowID);
        // 获取常量字段
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | 
                                            BindingFlags.Static | 
                                            BindingFlags.FlattenHierarchy);
        // 遍历字段
        foreach (FieldInfo field in fields)
        {
            // 检查字段类型是否为string
            if (field.FieldType == typeof(string)) 
            {
                // 获取字段值
                string value = (string)field.GetValue(null);
                // 获取字段名称
                string name = field.Name;
                windowConfigDict.Add(value, name);
            }
        }
    }

    public BasePanel GetUILogic(string path)
    {
        //检查缓存
        if (!windowConfigDict.TryGetValue(path, out string name))
        {
            Debug.LogError("界面不存在！！！");
            return null;
        }
        //检查是否已经打开
        if (!openWindowDict.TryGetValue(path, out BasePanel basePanel))
        {
            Debug.LogError("界面还未打开！！！");
            return null;
        }
        return basePanel;
    }
   public void ShowWindow(string path)
    {
        //检查缓存
        if (!windowConfigDict.TryGetValue(path, out string name))
        {
            Debug.LogError("界面不存在！！！");
            return;
        }
        //检查是否已经打开
        if (openWindowDict.TryGetValue(path, out BasePanel basePanel))
        {
            Debug.LogError("界面已经打开！！！");
            return;
        }
        //检查缓存
        if (!prefabWindowDict.TryGetValue(path, out GameObject go))
        {
            var obj = ResourceHelper.LoadGameObjectSync<GameObject>(path);
            //如果界面没有在缓存中则实例化一个
            prefabWindowDict.Add(path, obj);
            //打开界面
            var panelObject = GameObject.Instantiate(obj, UIRoot, false);
            if (panelObject.GetComponent(Type.GetType($"{obj.name}System")) == null)
                panelObject.AddComponent(Type.GetType($"{obj.name}System"));
                    

            basePanel = panelObject.GetComponent<BasePanel>();
            SetRoot(basePanel, GetTargetRoot(basePanel.windowType));
            openWindowDict.Add(path, basePanel);
                    
            //查看上一个最新打开的UI的
            if (openWindowStack.Count > 0)
            {
                var panel = openWindowStack.Peek();
                // panel.GetComponent<CanvasGroup>().interactable = false;
            }
            openWindowStack.Push(basePanel);
            basePanel.ShowWindow(path);
            return;
        }
        //如果有
        var panelObject1 = GameObject.Instantiate(go, UIRoot, false);
        if (panelObject1.GetComponent(Type.GetType($"{go.name}System")) == null)
            panelObject1.AddComponent(Type.GetType($"{go.name}System"));
        basePanel = panelObject1.GetComponent<BasePanel>();
        openWindowDict.Add(path, basePanel);
        //查看上一个最新打开的UI的
        if (openWindowStack.Count > 0)
        {
            var panel = openWindowStack.Peek();
            // panel.GetComponent<CanvasGroup>().interactable = false;
        }
        openWindowStack.Push(basePanel);
        basePanel.ShowWindow(path);
    }
    public void ShowWindow(string path, Action action)
    {
        //检查缓存
        if (!windowConfigDict.TryGetValue(path, out string name))
        {
            Debug.LogError("界面不存在！！！");
            return;
        }
        //检查是否已经打开
        if (openWindowDict.TryGetValue(path, out BasePanel basePanel))
        {
            Debug.LogError("界面已经打开！！！");
            return;
        }
        //检查缓存
        if (!prefabWindowDict.TryGetValue(path, out GameObject go))
        {
            var obj = ResourceHelper.LoadGameObjectSync<GameObject>(path);
            //如果界面没有在缓存中则实例化一个
            prefabWindowDict.Add(path, obj);
            //打开界面
            var panelObject = GameObject.Instantiate(obj, UIRoot, false);
            if (panelObject.GetComponent(Type.GetType($"{obj.name}System")) == null)
                panelObject.AddComponent(Type.GetType($"{obj.name}System"));
                    

            basePanel = panelObject.GetComponent<BasePanel>();
            openWindowDict.Add(path, basePanel);
                    
            //查看上一个最新打开的UI的
            if (openWindowStack.Count > 0)
            {
                var panel = openWindowStack.Peek();
                // panel.GetComponent<CanvasGroup>().interactable = false;
            }
            openWindowStack.Push(basePanel);
            basePanel.ShowWindow(path);
            action?.Invoke();
            return;
        }
        //如果有
        var panelObject1 = GameObject.Instantiate(go, UIRoot, false);
        if (panelObject1.GetComponent(Type.GetType($"{go.name}System")) == null)
            panelObject1.AddComponent(Type.GetType($"{go.name}System"));
        basePanel = panelObject1.GetComponent<BasePanel>();
        openWindowDict.Add(path, basePanel);
        //查看上一个最新打开的UI的
        if (openWindowStack.Count > 0)
        {
            var panel = openWindowStack.Peek();
            // panel.GetComponent<CanvasGroup>().interactable = false;
        }
        openWindowStack.Push(basePanel);
        basePanel.ShowWindow(path);
        action?.Invoke();
    }
   public bool CloseWindow(string path)
    {
        //检查是否打开
        if (!openWindowDict.TryGetValue(path, out BasePanel basePanel))
        {
            Debug.LogError("界面未打开，关闭失败");
            return false;
        }
        //关闭窗口
        basePanel.CloseWindow();
        //从字典中移除
        openWindowDict.Remove(path);
        //弹出栈
        openWindowStack.Pop();
        //如果栈不为空，设置可交互
        if (openWindowStack.Count > 0)
        {
            var panel = openWindowStack.Peek();
            // panel.GetComponent<CanvasGroup>().interactable = true;
        }
        return true;
    }
   public bool HideWindow(string path)
    {
        // 检查是否打开
        if (!openWindowDict.TryGetValue(path, out BasePanel basePanel))
        {
            Debug.LogError("界面未打开，关闭失败");
            return false;
        }
        // 隐藏窗口
        basePanel.HideWindow();
        // 从字典中移除
        openWindowDict.Remove(path);
        // 从堆栈中弹出
        openWindowStack.Pop();
        // 如果堆栈中还有元素，则将其设置为可交互
        if (openWindowStack.Count > 0)
        {
            var panel = openWindowStack.Peek();
            // panel.GetComponent<CanvasGroup>().interactable = true;
        }
        return true;
    }
   public Transform GetTargetRoot(UIWindowType type)
   {
       if (type == UIWindowType.Normal)
           return NormalRoot;
       else if (type == UIWindowType.Fixed)
           return FixedRoot;
       else if (type == UIWindowType.PopUp)
           return PopUpRoot;
       else if (type == UIWindowType.Other)
           return OtherRoot;
       Debug.LogError("uiroot type is error: " + type.ToString());
       return null;
   }
   public void SetRoot(BasePanel obj, Transform rootTransform)
   {
       obj.transform.SetParent(rootTransform);
       obj.transform.localScale = Vector3.one;
   }
}
