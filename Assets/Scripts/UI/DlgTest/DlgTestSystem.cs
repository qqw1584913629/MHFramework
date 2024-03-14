
using UnityEngine;
using UnityEngine.UI;
public class DlgTestSystem : BasePanel
{
	private DlgTestComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgTestComponent>() == null)
			self = gameObject.AddComponent<DlgTestComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Fixed;
	}
	private void Start()
	{
		self.M_LoopScrollList_EnhancedScroller.ReloadData();
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
