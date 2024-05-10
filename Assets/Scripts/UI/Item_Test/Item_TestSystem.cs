
using UnityEngine;
using UnityEngine.UI;
public class Item_TestSystem : BasePanel
{
	private Item_TestComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<Item_TestComponent>() == null)
			self = gameObject.AddComponent<Item_TestComponent>();
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
