
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
public class DlgTrueOrFalseSystem : BasePanel
{
	private DlgTrueOrFalseComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgTrueOrFalseComponent>() == null)
			self = gameObject.AddComponent<DlgTrueOrFalseComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
	}
	private void Start()
	{
		
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
