
using DG.Tweening;
using Model;
using UnityEngine;
using UnityEngine.UI;
public class DlgScoreCountSystem : BasePanel
{
	private DlgScoreCountComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgScoreCountComponent>() == null)
			self = gameObject.AddComponent<DlgScoreCountComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
	}
	private void Start()
	{
		self.M_CloseButton.AddListener(() =>
		{
			UIManager.Instance.HideWindow(WindowID.WindowID_ScoreCount);
		});
	}
	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
		self.MG_CenterRectTransform.localScale = Vector3.zero;
		self.MG_CenterRectTransform.DOScale(1, .15f);
		var i = PlayerPrefs.GetInt(PreName.Score.ToString());
		self.M_AllScoreTextMeshProUGUI.SetText($"总分数为：{i} 分");
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
