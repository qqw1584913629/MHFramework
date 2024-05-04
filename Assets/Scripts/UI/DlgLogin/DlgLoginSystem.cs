
using System;
using System.Security.Cryptography;
using System.Text;
using Helper;
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
		self.M_LoginButton.AddListener(OnLoginButtonClickHandler);
		self.M_RegisterButton.AddListener(OnRegisterButtonClickHandler);
		self.M_PasswordTMP_InputField.contentType = TMP_InputField.ContentType.Password;
	}

	private void OnRegisterButtonClickHandler()
	{
		//获取账号
		var account = self.M_AccountTMP_InputField.text;
		//获取密码
		var password = self.M_PasswordTMP_InputField.text;
		if (string.IsNullOrWhiteSpace(account) ||  string.IsNullOrWhiteSpace(password))
		{
			TipsHelper.ShowTipsInfo("账号或密码为空");
			return;
		}
		//创建账号信息
		AccountInfo accountInfo = new AccountInfo();
		//设置账号
		accountInfo.account = account;
		//md5加密密码
		accountInfo.password = MD5Helper.StringMD5(password);
		//设置角色
		accountInfo.role = Role.Normal;
		//保存账号信息
		SaveDataManager.SaveDataByPlayerPrefs(nameof(AccountInfo), accountInfo);
		TipsHelper.ShowTipsInfo("注册成功");
	}

	private void OnLoginButtonClickHandler()
	{
		var account = self.M_AccountTMP_InputField.text;
		var password = self.M_PasswordTMP_InputField.text;
		AccountInfo accountEntity = new AccountInfo();
		//特殊处理管理员
		if (account.Equals("admin") && password.Equals("admin"))
		{
			//管理员登录
			accountEntity.account = "admin";
			accountEntity.password = "admin";
			accountEntity.role = Role.Manager;
			GameManager.Instance.currentLoginAccountInfo = accountEntity;
			UIManager.Instance.ShowWindow(WindowID.WindowID_Main);
			UIManager.Instance.HideWindow(WindowID.WindowID_Login);
			return;
		}

		if (string.IsNullOrWhiteSpace(account) ||  string.IsNullOrWhiteSpace(password))
		{
			TipsHelper.ShowTipsInfo("账号或密码为空");
			return;
		}
		
		
		//首先判断是否有账号存在
		var accountInfo = JsonUtility.FromJson<AccountInfo>(SaveDataManager.LoadDataByPlayerPrefs(nameof(AccountInfo)));
		if (accountInfo == null)
		{
			//账号不存在
			TipsHelper.ShowTipsInfo("账号不存在");
			return;
		}
		//如果有账号则判断密码是否一致
		if (!accountInfo.password.Equals(MD5Helper.StringMD5(password)))
		{
			TipsHelper.ShowTipsInfo("密码错误");
			return;
		}
		accountEntity.account = account;
		accountEntity.role = accountInfo.role;
		UIManager.Instance.ShowWindow(WindowID.WindowID_Main);
		UIManager.Instance.HideWindow(WindowID.WindowID_Login);
		GameManager.Instance.currentLoginAccountInfo = accountEntity;
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
