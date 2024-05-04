
using Model;
using UnityEngine;
using UnityEngine.UI;
public class DlgClassQuestionSystem : BasePanel
{
	private DlgClassQuestionComponent self;
	private int level = 1;

	private void Awake()
	{
		if (gameObject.GetComponent<DlgClassQuestionComponent>() == null)
			self = gameObject.AddComponent<DlgClassQuestionComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
		level = PlayerPrefs.GetInt(PreName.SingleQuestion.ToString(), 1);

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
