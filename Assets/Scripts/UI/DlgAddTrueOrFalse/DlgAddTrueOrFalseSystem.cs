
using Helper;
using Model;
using UnityEngine;
using UnityEngine.UI;
public class DlgAddTrueOrFalseSystem : BasePanel
{
	private DlgAddTrueOrFalseComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgAddTrueOrFalseComponent>() == null)
			self = gameObject.AddComponent<DlgAddTrueOrFalseComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
	}
	private void Start()
	{
		self.M_SaveButton.AddListener(AddQuestionHandler);
		self.M_CloseButton.AddListener(()=>
		{
			UIManager.Instance.HideWindow(WindowID.WindowID_AddTrueOrFalse);
		});
	}

	private void AddQuestionHandler()
	{
		if (string.IsNullOrEmpty(self.M_QuestionTMP_InputField.text) ||
		    string.IsNullOrEmpty(self.M_TrueAnsTMP_InputField.text))
		{
			TipsHelper.ShowTipsInfo("有输入框未输入内容");
			return;
		}
		var trueOrFalseInfoComponent = JsonUtility.FromJson<TrueOrFalseInfoComponent>(SaveDataManager.LoadDataByPlayerPrefs(nameof(TrueOrFalseInfoComponent)));
		TrueOrFalseInfo trueOrFalse = new TrueOrFalseInfo();
		trueOrFalse.id = trueOrFalseInfoComponent.lists.Count + 1;
		trueOrFalse.question = self.M_QuestionTMP_InputField.text;
		trueOrFalse.ans = self.M_TrueAnsTMP_InputField.text;
		trueOrFalse.ans1 = "√";
		trueOrFalse.ans2 = "×";
		trueOrFalse.state = State.None;
		trueOrFalseInfoComponent.lists.Add(trueOrFalse);
		SaveDataManager.SaveDataByPlayerPrefs(nameof(TrueOrFalseInfoComponent), trueOrFalseInfoComponent);
		Refresh();
	}

	private void Refresh()
	{
		self.M_QuestionTMP_InputField.text = "";
		self.M_TrueAnsTMP_InputField.text = "";
	}

	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
		Refresh();
	}
	public override void HideWindow()
	{
		base.HideWindow();
		UIManager.Instance.GetUILogic<DlgTrueOrFalseManagerSystem>(WindowID.WindowID_TrueOrFalseManager).Reset();
	}
	public override void CloseWindow()
	{
		base.CloseWindow();
	}
}
