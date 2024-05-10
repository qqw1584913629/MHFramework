
using System.Collections.Generic;
using MH;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DlgTestSystem : BasePanel
{
	private DlgTestComponent self;
	public Dictionary<int, Scroll_Item_Test> ScrollItemServersMap;

	private void Awake()
	{
		if (gameObject.GetComponent<DlgTestComponent>() == null)
			self = gameObject.AddComponent<DlgTestComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Fixed;
	}
	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
		self.AddUIScrollItems(ref ScrollItemServersMap, 30);
		self.M_ServerLoopLoopScrollView.AddLoopScrollItemHandler(OnRefreshItemHandler);
		self.M_ServerLoopLoopScrollView.InitLoopScroll(true, ScrollItemServersMap.Count);

	}

	public void OnRefreshItemHandler(Transform transform1, int index, int moveState)
	{
		var scrollItemTest = ScrollItemServersMap[index].BindTrans(transform1);
		scrollItemTest.SetInfo(index);
	}
	public override void HideWindow()
	{
		base.HideWindow();
	}
	public override void CloseWindow()
	{
		base.CloseWindow();
	}
}
