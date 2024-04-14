
using Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DlgLoginSystem : BasePanel
{
	private DlgLoginComponent self;

	private int state = 0;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgLoginComponent>() == null)
			self = gameObject.AddComponent<DlgLoginComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Fixed;
	}
	private void Start()
	{
		self.M_LoginButtonButton.AddListener(OnLoginButtonClickHandler);
		self.M_PasswordTMP_InputField.contentType = TMP_InputField.ContentType.Password;
	}

	private void OnLoginButtonClickHandler()
	{
		var account = self.M_AccountTMP_InputField.text;
		var password = self.M_PasswordTMP_InputField.text;
		
		//首先判断是否有账号存在
		var accountInfo = JsonUtility.FromJson<AccountInfo>(SaveDataManager.LoadDataByPlayerPrefs(nameof(AccountInfo)));
		if (accountInfo == null)
		{
			//账号不存在
			UIManager.Instance.ShowWindow(WindowID.WindowID_Tips);
			UIManager.Instance.GetUILogic<DlgTipsSystem>(WindowID.WindowID_Tips).SetContent("账号不存在");
		}


		Debug.LogWarning($"account=>{account},password=>{password}");
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
