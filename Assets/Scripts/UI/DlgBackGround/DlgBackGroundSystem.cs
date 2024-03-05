
using UnityEngine;
using UnityEngine.UI;
public class DlgBackGroundSystem : BasePanel
{
	private DlgBackGroundComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgBackGroundComponent>() == null)
			self = gameObject.AddComponent<DlgBackGroundComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Fixed;
	}
	private void Start()
	{
		self.MLoginButton.AddListener(() =>
		{
			UIManager.Instance.ShowWindow(WindowID.WindowID_Login);
		});
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
