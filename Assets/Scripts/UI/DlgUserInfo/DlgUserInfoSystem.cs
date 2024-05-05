
using Helper;
using Model;
using UnityEngine;
using UnityEngine.UI;
public class DlgUserInfoSystem : BasePanel
{
	private DlgUserInfoComponent self;
	private AccountInfo _info;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgUserInfoComponent>() == null)
			self = gameObject.AddComponent<DlgUserInfoComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Normal;
	}
	private void Start()
	{
		self.M_CloseButton.AddListener(() =>
		{
			UIManager.Instance.ShowWindow(WindowID.WindowID_Main);
			UIManager.Instance.HideWindow(WindowID.WindowID_UserInfo);
		});
		self.M_SaveButton.AddListener(OnPasswordChangeHandler);
	}

	private void OnPasswordChangeHandler()
	{
		var text = self.M_BeforePasswordTMP_InputField.text;
		var origin = MD5Helper.StringMD5(text);
		var old = _info.password;
		if (!origin.Equals(old))
		{
			TipsHelper.ShowTipsInfo("原密码不正确");
			return;
		}
		var newPassword = MD5Helper.StringMD5(self.M_AfterPasswordTMP_InputField.text);
		_info.password = newPassword;
		SaveDataManager.SaveDataByPlayerPrefs(nameof(AccountInfo), _info);
		TipsHelper.ShowTipsInfo("修改密码成功");
	}

	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
		_info = JsonUtility.FromJson<AccountInfo>(SaveDataManager.LoadDataByPlayerPrefs(nameof(AccountInfo)));
		Refresh();
	}

	private void Refresh()
	{
		self.M_AccountTextMeshProUGUI.SetText(_info.account);
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
