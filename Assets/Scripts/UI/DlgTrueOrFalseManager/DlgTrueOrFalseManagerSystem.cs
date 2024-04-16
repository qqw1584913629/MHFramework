
using System.Collections.Generic;
using System.Linq;
using Model;
using Mono;
using UnityEngine;
using UnityEngine.UI;
public class DlgTrueOrFalseManagerSystem : BasePanel
{
	private DlgTrueOrFalseManagerComponent self;
	public List<TrueOrFalseInfo> trueOrFalseInfos = new List<TrueOrFalseInfo>();

	private void Awake()
	{
		if (gameObject.GetComponent<DlgTrueOrFalseManagerComponent>() == null)
			self = gameObject.AddComponent<DlgTrueOrFalseManagerComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
	}
	private void Start()
	{
		self.M_CloseButton.AddListener(() =>
		{
			UIManager.Instance.HideWindow(WindowID.WindowID_TrueOrFalseManager);
		});
		self.M_SearchButtonButton.AddListener(Search);
		self.M_AddButton.AddListener(AddButtonClickHandler);
	}

	private void AddButtonClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_AddTrueOrFalse);
	}

	private void Search()
	{
		var text = self.M_SearchInputTMP_InputField.text;
		if (string.IsNullOrEmpty(text))
		{
			Init();
			return;
		}

		var lists = trueOrFalseInfos.Where(s => s.question.Contains(text)).ToList();
		trueOrFalseInfos.Clear();
		trueOrFalseInfos = lists;
		Refresh();
	}

	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
		Init();
	}

	private void Init()
	{
		var trueOrFalseInfoComponent = JsonUtility.FromJson<TrueOrFalseInfoComponent>(SaveDataManager.LoadDataByPlayerPrefs(nameof(TrueOrFalseInfoComponent)));
		trueOrFalseInfos = trueOrFalseInfoComponent.lists;
		Refresh();
	}

	public void Reset()
	{
		for (int i = 0; i < self.MG_ContentRectTransform.childCount; i++)
			Destroy(self.MG_ContentRectTransform.GetChild(i).gameObject);
		var trueOrFalseInfoComponent = JsonUtility.FromJson<TrueOrFalseInfoComponent>(SaveDataManager.LoadDataByPlayerPrefs(nameof(TrueOrFalseInfoComponent)));
		trueOrFalseInfos = trueOrFalseInfoComponent.lists;
		foreach (var trueOrFalse in trueOrFalseInfos)
		{
			var loadGameObjectSync = ResourceHelper.LoadGameObjectSync<GameObject>(nameof(Item_TrueOrFalse));
			var go = Instantiate(loadGameObjectSync, self.MG_ContentRectTransform);
			var trueOrFalseInfo = go.GetComponent<Item_TrueOrFalse>();
			trueOrFalseInfo.SetInfo(trueOrFalse);
		}
	}

	public void Refresh()
	{
		for (int i = 0; i < self.MG_ContentRectTransform.childCount; i++)
			Destroy(self.MG_ContentRectTransform.GetChild(i).gameObject);
		foreach (var trueOrFalse in trueOrFalseInfos)
		{
			var loadGameObjectSync = ResourceHelper.LoadGameObjectSync<GameObject>(nameof(Item_TrueOrFalse));
			var go = Instantiate(loadGameObjectSync, self.MG_ContentRectTransform);
			var trueOrFalseInfo = go.GetComponent<Item_TrueOrFalse>();
			trueOrFalseInfo.SetInfo(trueOrFalse);
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
