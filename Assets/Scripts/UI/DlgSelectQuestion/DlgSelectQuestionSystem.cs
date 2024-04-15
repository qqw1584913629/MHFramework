
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
public class DlgSelectQuestionSystem : BasePanel
{
	private DlgSelectQuestionComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgSelectQuestionComponent>() == null)
			self = gameObject.AddComponent<DlgSelectQuestionComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
	}
	private void Start()
	{
		self.M_CloseButton.AddListener(()=>
		{
			UIManager.Instance.HideWindow(WindowID.WindowID_SelectQuestion);
		});
		self.M_SingleButton.AddListener(OnSingleClickHandler);
		self.M_TrueOrFalseButton.AddListener(OnTrueOrFalseClickHandler);
		self.M_DoubleButton.AddListener(OnDoubleClickHandler);
	}

	private void OnDoubleClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_DoubleQuestion);
		UIManager.Instance.HideWindow(WindowID.WindowID_SelectQuestion);
	}

	private void OnTrueOrFalseClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_TrueOrFalse);
		UIManager.Instance.HideWindow(WindowID.WindowID_SelectQuestion);
	}

	private void OnSingleClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_SingleQuestion);
		UIManager.Instance.HideWindow(WindowID.WindowID_SelectQuestion);
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
