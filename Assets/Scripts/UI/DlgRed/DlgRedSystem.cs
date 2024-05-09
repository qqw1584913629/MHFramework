
using UnityEngine;
using UnityEngine.UI;
public class DlgRedSystem : BasePanel
{
	private DlgRedComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgRedComponent>() == null)
			self = gameObject.AddComponent<DlgRedComponent>();
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
