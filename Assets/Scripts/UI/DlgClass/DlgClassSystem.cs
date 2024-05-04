
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
