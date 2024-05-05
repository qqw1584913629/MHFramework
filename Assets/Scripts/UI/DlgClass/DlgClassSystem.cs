
using UnityEngine;
using UnityEngine.UI;
public class DlgClassSystem : BasePanel
{
	private DlgClassComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgClassComponent>() == null)
			self = gameObject.AddComponent<DlgClassComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
	}
	private void Start()
	{
		self.M_ActButton.AddListener(ShowMainUI);
		self.M_BaseButton.AddListener(ShowMainUI);
		self.M_DefenseButton.AddListener(ShowMainUI);
		self.M_AttackButton.AddListener(ShowMainUI);
	}

	private void ShowMainUI()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_Main);
		UIManager.Instance.HideWindow(WindowID.WindowID_Class);
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
