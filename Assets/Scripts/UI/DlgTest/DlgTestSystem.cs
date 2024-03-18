
using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using MH;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class DlgTestSystem : BasePanel
{
	private DlgTestComponent self;
	public Dictionary<int, Scroll_Item_ServerInfo> ScrollItemServersMap;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgTestComponent>() == null)
			self = gameObject.AddComponent<DlgTestComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Fixed;
		self.M_LoopScrollList_MHLoopEnhancedScroller.AddItemRefreshListener((transform1, i) => ItemRefreshHandler(transform1, i));

	}
	private void Start()
	{
		self.AddUIScrollItems(ref ScrollItemServersMap, 30);
		self.M_LoopScrollList_MHLoopEnhancedScroller.SetVisible(true, 30);
	}

	private void ItemRefreshHandler(Transform transform1, int i)
	{
		var scrollItemServerInfo = ScrollItemServersMap[i].BindTrans(transform1);
		scrollItemServerInfo.M_TextTextMeshProUGUI.SetText(i.ToString());
		Debug.LogWarning($"{i}-{transform1.name}");
	}

	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
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
