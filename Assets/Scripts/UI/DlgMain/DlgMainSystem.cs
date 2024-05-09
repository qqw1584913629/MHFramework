
using Model;
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
		self.M_AdminButton.AddListener(OnManagerClickHandler);
		self.M_QuitButton.AddListener(OnQuitAccountClickHandler);
		self.M_UserInfoButton.AddListener(OnUserInfoClickHandler);
		self.M_StudioButton.AddListener(OnStudioClickHandler);
	}

	private void OnUserInfoClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_UserInfo);
		UIManager.Instance.HideWindow(WindowID.WindowID_Main);
	}

	private void OnQuitAccountClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_Login);
		UIManager.Instance.HideWindow(WindowID.WindowID_Main);
	}

	private void OnManagerClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_SelectManager);
		UIManager.Instance.HideWindow(WindowID.WindowID_Main);
	}

	private void OnScoreCountClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_ScoreCount);
		UIManager.Instance.HideWindow(WindowID.WindowID_Main);
	}

	private void OnStudioClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_Studio);
		UIManager.Instance.HideWindow(WindowID.WindowID_Main);
	}

	private void OnQuestionClickHandler()
	{
		UIManager.Instance.ShowWindow(WindowID.WindowID_SelectQuestion);
		UIManager.Instance.HideWindow(WindowID.WindowID_Main);
	}

	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
		Refresh();
	}

	private void Refresh()
	{
		self.M_AdminButton.SetVisible(GameManager.Instance.currentLoginAccountInfo.role == Role.Manager);
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
