
using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using UnityEngine;
using UnityEngine.UI;
public class DlgSingleManagerSystem : BasePanel
{
	private DlgSingleManagerComponent self;
	public List<SingleInfo> singleInfos = new List<SingleInfo>();
	private void Awake()
	{
		if (gameObject.GetComponent<DlgSingleManagerComponent>() == null)
			self = gameObject.AddComponent<DlgSingleManagerComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
	}
	private void Start()
	{
		self.M_CloseButton.AddListener(() =>
		{
			UIManager.Instance.HideWindow(WindowID.WindowID_SingleManager);
		});
		self.M_SearchButtonButton.AddListener(Search);
		self.M_AddButton.AddListener(AddButtonClickHandler);
	}

	private void AddButtonClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_AddSingle);
	}

	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
		Init();
	}

	private void Init()
	{
		var singleInfoComponent = JsonUtility.FromJson<SingleInfoComponent>(SaveDataManager.LoadDataByPlayerPrefs(nameof(SingleInfoComponent)));
		singleInfos = singleInfoComponent.lists;
		Refresh();
	}

	public void Reset()
	{
		for (int i = 0; i < self.MG_ContentRectTransform.childCount; i++)
			Destroy(self.MG_ContentRectTransform.GetChild(i).gameObject);
		var singleInfoComponent = JsonUtility.FromJson<SingleInfoComponent>(SaveDataManager.LoadDataByPlayerPrefs(nameof(SingleInfoComponent)));
		singleInfos = singleInfoComponent.lists;
		foreach (var single in singleInfos)
		{
			var loadGameObjectSync = ResourceHelper.LoadGameObjectSync<GameObject>(nameof(Item_Single));
			var go = Instantiate(loadGameObjectSync, self.MG_ContentRectTransform);
			var itemSingle = go.GetComponent<Item_Single>();
			itemSingle.SetInfo(single);
		}
	}

	public void Refresh()
	{
		for (int i = 0; i < self.MG_ContentRectTransform.childCount; i++)
			Destroy(self.MG_ContentRectTransform.GetChild(i).gameObject);
		foreach (var single in singleInfos)
		{
			var loadGameObjectSync = ResourceHelper.LoadGameObjectSync<GameObject>(nameof(Item_Single));
			var go = Instantiate(loadGameObjectSync, self.MG_ContentRectTransform);
			var itemSingle = go.GetComponent<Item_Single>();
			itemSingle.SetInfo(single);
		}
	}
	public void Search()
	{
		var text = self.M_SearchInputTMP_InputField.text;
		if (string.IsNullOrEmpty(text))
		{
			Init();
			return;
		}

		var lists = singleInfos.Where(s => s.question.Contains(text)).ToList();
		singleInfos.Clear();
		singleInfos = lists;
		Refresh();
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
