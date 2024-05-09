
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using Helper;
using Model;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Random = System.Random;

public class DlgSingleQuestionSystem : BasePanel
{
	private DlgSingleQuestionComponent self;
	private int level = 1;
	private string ans;
	private int cur_Score;
	private List<string> ansList = new List<string>();
	private void Awake()
	{
		if (gameObject.GetComponent<DlgSingleQuestionComponent>() == null)
			self = gameObject.AddComponent<DlgSingleQuestionComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
		level = PlayerPrefs.GetInt(PreName.SingleQuestion.ToString(), 1);
	}
	private void Start()
	{
		self.M_CloseButton.AddListener(() =>
		{
			UIManager.Instance.HideWindow(WindowID.WindowID_SingleQuestion);
		});
		self.M_Ans1Button.AddListener(() =>
		{
			SubmitAns(self.M_Ans1TextTextMeshProUGUI);
		});
		self.M_Ans2Button.AddListener(() =>
		{
			SubmitAns(self.M_Ans2TextTextMeshProUGUI);
		});
		self.M_Ans3Button.AddListener(() =>
		{
			SubmitAns(self.M_Ans3TextTextMeshProUGUI);
		});
		self.M_Ans4Button.AddListener(() =>
		{
			SubmitAns(self.M_Ans4TextTextMeshProUGUI);
		});
	}
	private int timer;
	private int round;
	private IEnumerator CO_TimeCount()
	{
		while (true)
		{
			int minutes = timer / 60; // 获取分钟数
			int seconds = timer % 60; // 获取余下的秒数
			self.M_TimeDownTextMeshProUGUI.SetText($"{minutes:D2}:{seconds:D2}");
			yield return new WaitForSeconds(1f);
			timer++;
		}
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
			PlayerPrefs.SetInt(PreName.SingleQuestion.ToString(), level);
			var i = PlayerPrefs.GetInt(PreName.Score.ToString(), 0);
			i += 5;
			cur_Score += 5;
			PlayerPrefs.SetInt(PreName.Score.ToString(), i);
			Refresh();
			round++;
			if (round >= 10)
			{
				TipsHelper.ShowTipsInfo($"答题结束，本轮分数为：{cur_Score} 分", timer);
				UIManager.Instance.HideWindow(WindowID.WindowID_SingleQuestion);
			}
		}
		else
			text.color = Color.red;
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
	private void Refresh()
	{
		self.M_Ans1TextTextMeshProUGUI.color = Color.white;
		self.M_Ans2TextTextMeshProUGUI.color = Color.white;
		self.M_Ans3TextTextMeshProUGUI.color = Color.white;
		self.M_Ans4TextTextMeshProUGUI.color = Color.white;

		ansList.Clear();
		var singleInfoComponent = JsonUtility.FromJson<SingleInfoComponent>(SaveDataManager.LoadDataByPlayerPrefs(nameof(SingleInfoComponent)));
		if (level >= singleInfoComponent.lists.Count)
		{
			TipsHelper.ShowTipsInfo($"答题结束，本轮分数为：{cur_Score} 分", timer);
			self.M_QuestionTextMeshProUGUI.SetText("已完成全部题目");
			self.M_Ans1Button.SetVisible(false);
			self.M_Ans2Button.SetVisible(false);
			self.M_Ans3Button.SetVisible(false);
			self.M_Ans4Button.SetVisible(false);
			return;
		}
		var config = singleInfoComponent.lists[level];
		if (config.state == State.Remove || config.questionState == QuestionState.Finish)
		{
			level++;
			Refresh();
			return;
		}
		ans = config.ans;
		ansList.Add(config.ans1);
		ansList.Add(config.ans2);
		ansList.Add(config.ans3);
		ansList.Add(config.ans4);
		ShuffleList(ansList);
		self.M_QuestionTextMeshProUGUI.SetText(config.question);
		self.M_Ans1TextTextMeshProUGUI.SetText($"A.{ansList[0]}");
		self.M_Ans2TextTextMeshProUGUI.SetText($"B.{ansList[1]}");
		self.M_Ans3TextTextMeshProUGUI.SetText($"C.{ansList[2]}");
		self.M_Ans4TextTextMeshProUGUI.SetText($"D.{ansList[3]}");
	}
	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
		self.MG_CenterRectTransform.localScale = Vector3.zero;
		self.MG_CenterRectTransform.DOScale(1, .15f);
		cur_Score = 0;
		timer = 0;
		round = 0;
		StartCoroutine(CO_TimeCount());
		Refresh();
	}
	public override void HideWindow()
	{
		base.HideWindow();
		UIManager.Instance.ShowWindow(WindowID.WindowID_Main);
		StopAllCoroutines();

	}
	public override void CloseWindow()
	{
		base.CloseWindow();
	}
}
