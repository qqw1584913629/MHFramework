
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
public class DlgTipsSystem : BasePanel
{
	private DlgTipsComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgTipsComponent>() == null)
			self = gameObject.AddComponent<DlgTipsComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Other;
	}
	private void Start()
	{
		self.M_CloseButton.AddListener(() =>
		{
			UIManager.Instance.HideWindow(WindowID.WindowID_Tips);
		});
	}

	public void SetContent(string content)
	{
		self.M_ConentTextMeshProUGUI.SetText(content);
	}
	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
		self.MG_CenterRectTransform.localScale = Vector3.zero;
		self.MG_CenterRectTransform.DOScale(1, .15f);
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
