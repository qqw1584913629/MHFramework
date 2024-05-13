
using System.Collections.Generic;
using MH;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public static class DlgTestSystem
{
	public static void RegisterUIEvent(this DlgTestComponent self)
	{
		self.M_ServerLoopLoopScrollView.AddLoopScrollItemHandler(self.OnRefreshItemHandler);
	}
	public static void ShowWindow(this DlgTestComponent self, object context = null)
	{
		self.AddUIScrollItems(ref self.ScrollItemServersMap, 30);
		self.M_ServerLoopLoopScrollView.InitLoopScroll(true, self.ScrollItemServersMap.Count);
	}

	public static void OnRefreshItemHandler(this DlgTestComponent self, Transform transform1, int index, int moveState)
	{
		var scrollItemTest = self.ScrollItemServersMap[index].BindTrans(transform1);
		scrollItemTest.SetInfo(index);
	}
}
