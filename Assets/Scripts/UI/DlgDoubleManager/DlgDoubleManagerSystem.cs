
using System.Collections.Generic;
using System.Linq;
using Model;
using Mono;
using UnityEngine;
using UnityEngine.UI;
public class DlgDoubleManagerSystem : BasePanel
{
	private DlgDoubleManagerComponent self;
	public List<DoubleInfo> doubleInfos = new List<DoubleInfo>();
	private void Awake()
	{
		if (gameObject.GetComponent<DlgDoubleManagerComponent>() == null)
			self = gameObject.AddComponent<DlgDoubleManagerComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
	}
	private void Start()
	{
		self.M_CloseButton.AddListener(()=>
		{
			UIManager.Instance.HideWindow(WindowID.WindowID_DoubleManager);
		});
		self.M_SearchButtonButton.AddListener(Search);
		self.M_AddButton.AddListener(AddButtonClickHandler);
	}

	private void AddButtonClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_AddSingle);
	}

	private void Search()
	{
		var text = self.M_SearchInputTMP_InputField.text;
		if (string.IsNullOrEmpty(text))
		{
			Init();
			return;
		}

		var lists = doubleInfos.Where(s => s.question.Contains(text)).ToList();
		doubleInfos.Clear();
		doubleInfos = lists;
		Refresh();
	}

	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
		Init();
	}

	private void Init()
	{
		var doubleInfoComponent = JsonUtility.FromJson<DoubleInfoComponent>(SaveDataManager.LoadDataByPlayerPrefs(nameof(DoubleInfoComponent)));
		doubleInfos = doubleInfoComponent.lists;
		Refresh();
	}

	private void Refresh()
	{
		for (int i = 0; i < self.MG_ContentRectTransform.childCount; i++)
			Destroy(self.MG_ContentRectTransform.GetChild(i).gameObject);
		foreach (var doubleInfo in doubleInfos)
		{
			var loadGameObjectSync = ResourceHelper.LoadGameObjectSync<GameObject>(nameof(Item_Double));
			var go = Instantiate(loadGameObjectSync, self.MG_ContentRectTransform);
			var itemDouble = go.GetComponent<Item_Double>();
			itemDouble.SetInfo(doubleInfo);
		}
	}
	public void Reset()
	{
		for (int i = 0; i < self.MG_ContentRectTransform.childCount; i++)
			Destroy(self.MG_ContentRectTransform.GetChild(i).gameObject);
		var doubleInfoComponent = JsonUtility.FromJson<DoubleInfoComponent>(SaveDataManager.LoadDataByPlayerPrefs(nameof(DoubleInfoComponent)));
		doubleInfos = doubleInfoComponent.lists;
		foreach (var doubleInfo in doubleInfos)
		{
			var loadGameObjectSync = ResourceHelper.LoadGameObjectSync<GameObject>(nameof(Item_Double));
			var go = Instantiate(loadGameObjectSync, self.MG_ContentRectTransform);
			var itemDouble = go.GetComponent<Item_Double>();
			itemDouble.SetInfo(doubleInfo);
		}
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
