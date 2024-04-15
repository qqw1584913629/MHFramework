
using Helper;
using Model;
using UnityEngine;
using UnityEngine.UI;
public class DlgAddSingleSystem : BasePanel
{
	private DlgAddSingleComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgAddSingleComponent>() == null)
			self = gameObject.AddComponent<DlgAddSingleComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
	}
	private void Start()
	{
		self.M_SaveButton.AddListener(AddQuestionHandler);
		self.M_CloseButton.AddListener(()=>
		{
			UIManager.Instance.HideWindow(WindowID.WindowID_AddSingle);
		});
	}

	private void AddQuestionHandler()
	{
		if (string.IsNullOrEmpty(self.M_QuestionTMP_InputField.text) ||
		    string.IsNullOrEmpty(self.M_TrueAnsTMP_InputField.text) ||
		    string.IsNullOrEmpty(self.M_Ans1TMP_InputField.text) ||
		    string.IsNullOrEmpty(self.M_Ans2TMP_InputField.text) ||
		    string.IsNullOrEmpty(self.M_Ans3TMP_InputField.text) ||
		    string.IsNullOrEmpty(self.M_Ans4TMP_InputField.text))
		{
			TipsHelper.ShowTipsInfo("有输入框未输入内容");
			return;
		}
		var singleInfoComponent = JsonUtility.FromJson<SingleInfoComponent>(SaveDataManager.LoadDataByPlayerPrefs(nameof(SingleInfoComponent)));
		SingleInfo singleInfo = new SingleInfo();
		singleInfo.id = singleInfoComponent.lists.Count + 1;
		singleInfo.question = self.M_QuestionTMP_InputField.text;
		singleInfo.ans = self.M_TrueAnsTMP_InputField.text;
		singleInfo.ans1 = self.M_Ans1TMP_InputField.text;
		singleInfo.ans2 = self.M_Ans2TMP_InputField.text;
		singleInfo.ans3 = self.M_Ans3TMP_InputField.text;
		singleInfo.ans4 = self.M_Ans4TMP_InputField.text;
		singleInfo.state = State.None;
		singleInfoComponent.lists.Add(singleInfo);
		SaveDataManager.SaveDataByPlayerPrefs(nameof(SingleInfoComponent), singleInfoComponent);
		Refresh();
	}

	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
		Refresh();
	}

	private void Refresh()
	{
		self.M_QuestionTMP_InputField.text = "";
		self.M_TrueAnsTMP_InputField.text = "";
		self.M_Ans1TMP_InputField.text = "";
		self.M_Ans2TMP_InputField.text = "";
		self.M_Ans3TMP_InputField.text = "";
		self.M_Ans4TMP_InputField.text = "";
	}

	public override void HideWindow()
	{
		base.HideWindow();
		UIManager.Instance.GetUILogic<DlgSingleManagerSystem>(WindowID.WindowID_SingleManager).Reset();
	}
	public override void CloseWindow()
	{
		base.CloseWindow();
	}
}
