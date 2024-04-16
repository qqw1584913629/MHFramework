
using UnityEngine;
using UnityEngine.UI;
public class DlgAddTrueOrFalseSystem : BasePanel
{
	private DlgAddTrueOrFalseComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgAddTrueOrFalseComponent>() == null)
			self = gameObject.AddComponent<DlgAddTrueOrFalseComponent>();
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
