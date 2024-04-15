
using System.Collections.Generic;
using DG.Tweening;
using Helper;
using Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class DlgTrueOrFalseSystem : BasePanel
{
	private DlgTrueOrFalseComponent self;
	private int level = 1;
	private string ans;
	private int cur_Score;
	private List<string> ansList = new List<string>();
	private void Awake()
	{
		if (gameObject.GetComponent<DlgTrueOrFalseComponent>() == null)
			self = gameObject.AddComponent<DlgTrueOrFalseComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
		level = PlayerPrefs.GetInt(PreName.TrueOrFalse.ToString(), 1);
	}
	private void Start()
	{
		self.M_CloseButton.AddListener(() =>
		{
			UIManager.Instance.HideWindow(WindowID.WindowID_TrueOrFalse);
		});
		self.M_Ans1Button.AddListener(() =>
		{
			SubmitAns(self.M_Ans1TextTextMeshProUGUI);
		});
		self.M_Ans2Button.AddListener(() =>
		{
			SubmitAns(self.M_Ans2TextTextMeshProUGUI);
		});
	}

	private void SubmitAns(TextMeshProUGUI text)
	{
		var s = text.text.Split(".")[1];
		if (s.Equals(ans))
		{
			//答案正确
			text.color = Color.green;

			//下一题
			level++;
			PlayerPrefs.SetInt(PreName.TrueOrFalse.ToString(), level);
			var i = PlayerPrefs.GetInt(PreName.Score.ToString(), 0);
			i += 5;
			cur_Score += 5;
			PlayerPrefs.SetInt(PreName.Score.ToString(), i);
			Refresh();
		}
		else
			text.color = Color.red;
	}

	private void Refresh()
	{
		self.M_Ans1TextTextMeshProUGUI.color = Color.white;
		self.M_Ans2TextTextMeshProUGUI.color = Color.white;
		ansList.Clear();
		var trueOrFalseInfoComponent = JsonUtility.FromJson<TrueOrFalseInfoComponent>(SaveDataManager.LoadDataByPlayerPrefs(nameof(TrueOrFalseInfoComponent)));
		if (level >= trueOrFalseInfoComponent.lists.Count)
		{
			TipsHelper.ShowTipsInfo($"答题结束，本轮分数为：{cur_Score} 分");
			self.M_QuestionTextMeshProUGUI.SetText("已完成全部题目");
			self.M_Ans1Button.SetVisible(false);
			self.M_Ans2Button.SetVisible(false);
			return;
		}
		var config = trueOrFalseInfoComponent.lists[level];
		ans = config.ans;
		ansList.Add(config.ans1);
		ansList.Add(config.ans2);
		ShuffleList(ansList);
		self.M_QuestionTextMeshProUGUI.SetText(config.question);
		self.M_Ans1TextTextMeshProUGUI.SetText($"A.{ansList[0]}");
		self.M_Ans2TextTextMeshProUGUI.SetText($"B.{ansList[1]}");
	}
	void ShuffleList(List<string> list)
	{
		Random random = new Random();
		int n = list.Count;

		for (int i = 0; i < n - 1; i++)
		{
			int j = random.Next(i, n);
			(list[i], list[j]) = (list[j], list[i]);
		}
	}
	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
		self.MG_CenterRectTransform.localScale = Vector3.zero;
		self.MG_CenterRectTransform.DOScale(1, .15f);
		cur_Score = 0;
		Refresh();
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
