
using UnityEngine;
using UnityEngine.UI;
public class DlgLoginSystem : BasePanel
{
	private DlgLoginComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgLoginComponent>() == null)
			self = gameObject.AddComponent<DlgLoginComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Fixed;
	}
	private void Start()
	{
		
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
