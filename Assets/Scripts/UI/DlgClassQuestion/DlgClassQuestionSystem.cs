
using System;
using System.Collections.Generic;
using Helper;
using Model;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class DlgClassQuestionSystem : BasePanel
{
	private DlgClassQuestionComponent self;
	private int level = 1;
	private List<string> ansList = new List<string>();
	private string ans;
	private int cur_Score;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgClassQuestionComponent>() == null)
			self = gameObject.AddComponent<DlgClassQuestionComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
		// level = PlayerPrefs.GetInt(PreName.BaseClass.ToString(), 1);

	}
	private void Refresh()
	{
		// DestroChild();
		// self.M_Ans1TextTextMeshProUGUI.color = Color.white;
		// self.M_Ans2TextTextMeshProUGUI.color = Color.white;
		// self.M_Ans3TextTextMeshProUGUI.color = Color.white;
		// self.M_Ans4TextTextMeshProUGUI.color = Color.white;
		//
		// ansList.Clear();
		// var singleInfoComponent = JsonUtility.FromJson<SingleInfoComponent>(SaveDataManager.LoadDataByPlayerPrefs(nameof(SingleInfoComponent)));
		// if (level >= singleInfoComponent.lists.Count)
		// {
		// 	TipsHelper.ShowTipsInfo($"答题结束，本轮分数为：{cur_Score} 分");
		// 	self.M_QuestionTextMeshProUGUI.SetText("已完成全部题目");
		// 	return;
		// }
		// var config = singleInfoComponent.lists[level];
		// if (config.state == State.Remove || config.questionState == QuestionState.Finish)
		// {
		// 	level++;
		// 	Refresh();
		// 	return;
		// }
		// ans = config.ans;
		// ansList.Add(config.ans1);
		// ansList.Add(config.ans2);
		// ansList.Add(config.ans3);
		// ansList.Add(config.ans4);
		// ShuffleList(ansList);
		// self.M_QuestionTextMeshProUGUI.SetText(config.question);
		// self.M_Ans1TextTextMeshProUGUI.SetText($"A.{ansList[0]}");
		// self.M_Ans2TextTextMeshProUGUI.SetText($"B.{ansList[1]}");
		// self.M_Ans3TextTextMeshProUGUI.SetText($"C.{ansList[2]}");
		// self.M_Ans4TextTextMeshProUGUI.SetText($"D.{ansList[3]}");
	}

	private void DestroChild()
	{
		for (int i = 0; i < self.MG_OptionsRectTransform.childCount; i++)
		{
			Destroy(self.MG_OptionsRectTransform.GetChild(0).gameObject);
		}
	}

	void ShuffleList(List<string> list)
	{
		// Random random = new Random();
		// int n = list.Count;
		//
		// for (int i = 0; i < n - 1; i++)
		// {
		// 	int j = random.Next(i, n);
		// 	(list[i], list[j]) = (list[j], list[i]);
		// }
	}
	private void Start()
	{
		// self.button
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
