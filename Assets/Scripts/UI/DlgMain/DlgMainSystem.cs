
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
	}

	private void OnStudioClickHandler()
	{
		
	}

	private void OnQuestionClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_SelectQuestion);
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
