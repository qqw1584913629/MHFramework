
using System.Collections.Generic;
using System.Linq;
using Helper;
using Model;
using UnityEngine;
using UnityEngine.UI;
public class DlgAddDoubleSystem : BasePanel
{
	private DlgAddDoubleComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgAddDoubleComponent>() == null)
			self = gameObject.AddComponent<DlgAddDoubleComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
	}
	private void Start()
	{
		self.M_SaveButton.AddListener(AddQuestionHandler);
		self.M_CloseButton.AddListener(()=>
		{
			UIManager.Instance.HideWindow(WindowID.WindowID_AddDouble);
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
		List<string> tmps = new List<string>();
		tmps.Add(self.M_Ans1TMP_InputField.text);
		tmps.Add(self.M_Ans2TMP_InputField.text);
		tmps.Add(self.M_Ans3TMP_InputField.text);
		tmps.Add(self.M_Ans4TMP_InputField.text);
		var doubleInfoAns = self.M_TrueAnsTMP_InputField.text.Split("|").ToList();
		if (tmps.Contains(doubleInfoAns[0]) && tmps.Contains(doubleInfoAns[1]))
		{
			var doubleInfoComponent = JsonUtility.FromJson<DoubleInfoComponent>(SaveDataManager.LoadDataByPlayerPrefs(nameof(DoubleInfoComponent)));
			DoubleInfo doubleInfo = new DoubleInfo();
			doubleInfo.id = doubleInfoComponent.lists.Count + 1;
			doubleInfo.question = self.M_QuestionTMP_InputField.text;
			doubleInfo.ans = doubleInfoAns;
			doubleInfo.ans1 = self.M_Ans1TMP_InputField.text;
			doubleInfo.ans2 = self.M_Ans2TMP_InputField.text;
			doubleInfo.ans3 = self.M_Ans3TMP_InputField.text;
			doubleInfo.ans4 = self.M_Ans4TMP_InputField.text;
			doubleInfo.state = State.None;
			doubleInfoComponent.lists.Add(doubleInfo);
			SaveDataManager.SaveDataByPlayerPrefs(nameof(DoubleInfoComponent), doubleInfoComponent);
			Refresh();
		}
		else
		{
			TipsHelper.ShowTipsInfo("答案未包含正确答案在内");
			return;
		}
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
	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
		Refresh();
	}
	public override void HideWindow()
	{
		base.HideWindow();
		UIManager.Instance.GetUILogic<DlgDoubleManagerSystem>(WindowID.WindowID_DoubleManager).Reset();
	}
	public override void CloseWindow()
	{
		base.CloseWindow();
	}
}
