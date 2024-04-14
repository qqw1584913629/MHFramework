
using UnityEngine;
using UnityEngine.UI;
public class DlgTipsSystem : BasePanel
{
	private DlgTipsComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgTipsComponent>() == null)
			self = gameObject.AddComponent<DlgTipsComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Other;
	}
	private void Start()
	{
		self.M_CloseButton.AddListener(() =>
		{
			UIManager.Instance.HideWindow(WindowID.WindowID_Tips);
		});
		
		
		// self.MG_MaskRectTransform.
	}

	public void SetContent(string content)
	{
		self.M_ConentTextMeshProUGUI.SetText(content);
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
