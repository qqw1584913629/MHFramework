
using UnityEngine;
using UnityEngine.UI;
public class DlgMainSystem : BasePanel
{
	private DlgMainComponent self;
	
	private void Awake()
	{
		if (gameObject.GetComponent<DlgMainComponent>() == null)
			self = gameObject.AddComponent<DlgMainComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
	}
	private void Start()
	{
		self.M_StudioButton.AddListener(OnStudioClickHandler);
		self.M_QuestionButton.AddListener(OnQuestionClickHandler);
		self.M_ScoreCountButton.AddListener(OnScoreCountClickHandler);
	}

	private void OnScoreCountClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_ScoreCount);
		UIManager.Instance.HideWindow(WindowID.WindowID_Main);
	}

	private void OnStudioClickHandler()
	{
		// UIManager.Instance.ShowWindow(WindowID.WindowID_SelectQuestion);
		// UIManager.Instance.HideWindow(WindowID.WindowID_Main);
	}

	private void OnQuestionClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_SelectQuestion);
		UIManager.Instance.HideWindow(WindowID.WindowID_Main);
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
