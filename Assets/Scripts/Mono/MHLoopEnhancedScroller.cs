#region << 文 件 说 明 >>

/*----------------------------------------------------------------
// 文件名称：MHLoopEnhancedScroller
// 创 建 者：郑以航
// 创建时间：2024年03月16日 星期六 22:30
//===============================================================
// 功能描述：
//		
//
//----------------------------------------------------------------*/

#endregion

using System;
using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using UnityEngine;

public class MHLoopEnhancedScroller : EnhancedScroller, IEnhancedScrollerDelegate
{
    private Action<Transform,int> scrollMoveEvent;
    private int totalCount;
    [SerializeField]
    private string prefabName;
    public void SetVisible(bool isVisible,int count = 0)
    {
        transform.gameObject.SetActive(isVisible);
        totalCount = count;
        Delegate = this;
        ReloadData();
    }
    public int GetNumberOfCells(EnhancedScroller scroller)
    {
        return totalCount;
    }

    public float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
    {
        return 100f;
    }

    public EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
    {
        var loadGameObjectSync = ResourceHelper.LoadGameObjectSync<GameObject>(prefabName);
        var enhancedScroller = loadGameObjectSync.GetComponent<EnhancedScrollerCellView>();
        EnhancedScrollerCellView cellView = scroller.GetCellView(enhancedScroller);  //生成GameObject，
        this.scrollMoveEvent?.Invoke(cellView.transform, dataIndex);
        return cellView; //设置好Prefab的EnhancedScrollerCellView 的数据，然后返回数据设置完成的EnhancedScrollerCellView
    }
    public void AddItemRefreshListener(Action<Transform,int> scrollMoveEvent)
    {
        if (scrollMoveEvent == null )
            return;
        this.scrollMoveEvent = null;
        this.scrollMoveEvent = scrollMoveEvent;
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
            return;
        }
            
        // foreach (var item in dictionary)
        // {
        //     item.Value.Dispose();
        // }
        dictionary.Clear();
        for (int i = 0; i <= count; i++)
        {
            Type type = typeof (T);
            IUIScrollItem component = Activator.CreateInstance(type) as IUIScrollItem;
            T itemServer = (T)component;
            dictionary.Add(i , itemServer);
        }
    }
}