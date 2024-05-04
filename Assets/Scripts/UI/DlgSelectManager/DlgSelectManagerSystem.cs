
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
public class DlgSelectManagerSystem : BasePanel
{
	private DlgSelectManagerComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgSelectManagerComponent>() == null)
			self = gameObject.AddComponent<DlgSelectManagerComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
	}
	private void Start()
	{
		self.M_CloseButton.AddListener(()=>
		{
			UIManager.Instance.HideWindow(WindowID.WindowID_SelectManager);
			UIManager.Instance.ShowWindow(WindowID.WindowID_Main);

		});
		self.M_SingleButton.AddListener(OnSingleClickHandler);
		self.M_TrueOrFalseButton.AddListener(OnTrueOrFalseClickHandler);
		self.M_DoubleButton.AddListener(OnDoubleClickHandler);
	}
	private void OnDoubleClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_DoubleManager);
		UIManager.Instance.HideWindow(WindowID.WindowID_SelectManager);
	}

	private void OnTrueOrFalseClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_TrueOrFalseManager);
		UIManager.Instance.HideWindow(WindowID.WindowID_SelectManager);
	}

	private void OnSingleClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_SingleManager);
		UIManager.Instance.HideWindow(WindowID.WindowID_SelectManager);
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
