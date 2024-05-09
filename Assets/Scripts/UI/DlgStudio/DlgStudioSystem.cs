
using System.Collections.Generic;
using cfg;
using UnityEngine;
using UnityEngine.UI;
public class DlgStudioSystem : BasePanel
{
	private DlgStudioComponent self;
	private List<StudioConfig> studioConfigs = new List<StudioConfig>();

	private void Awake()
	{
		if (gameObject.GetComponent<DlgStudioComponent>() == null)
			self = gameObject.AddComponent<DlgStudioComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
	}
	private void Start()
	{
		self.M_CloseButton.AddListener(() =>
		{
			if (!self.MG_StudioRectTransform.gameObject.activeSelf)
			{
				UIManager.Instance.HideWindow(WindowID.WindowID_Studio);
			}
			else
			{
				self.MG_StudioRectTransform.SetVisible(false);
			}
		});
	}
	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
		Init();
	}
	private void Init()
	{
		studioConfigs = ConfigsManager.tables.TbStudio.DataList;
		Refresh();
	}
	public void Refresh()
	{
		for (int i = 0; i < self.MG_ContentRectTransform.childCount; i++)
			Destroy(self.MG_ContentRectTransform.GetChild(i).gameObject);
		foreach (var config in studioConfigs)
		{
			var loadGameObjectSync = ResourceHelper.LoadGameObjectSync<GameObject>(nameof(Item_Studio));
			var go = Instantiate(loadGameObjectSync, self.MG_ContentRectTransform);
			var itemSingle = go.GetComponent<Item_Studio>();
			itemSingle.SetInfo(config);
		}
		self.MG_StudioRectTransform.SetVisible(false);
	}
	public void Play(bool isPlay)
	{
		self.MG_StudioRectTransform.SetVisible(isPlay);
	}
	
	public override void HideWindow()
	{
		base.HideWindow();
		UIManager.Instance.ShowWindow(WindowID.WindowID_Main);

	}
	public override void CloseWindow()
	{
		base.CloseWindow();
	}
}
