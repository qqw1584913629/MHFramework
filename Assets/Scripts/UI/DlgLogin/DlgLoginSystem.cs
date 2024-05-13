
using UnityEngine;
using UnityEngine.UI;
namespace MH
{
	public static class DlgLoginSystem 
	{
		public static void RegisterUIEvent(this DlgLoginComponent self)
		{
			self.M_LoginButtonButton.AddListener(self.OnLoginButtonClickHandler);
			self.M_LoginButton2Button.AddListener(self.OnLoginButton2ClickHandler);
			self.M_CloseButton.AddListener(() =>
			{
				UIManager.Instance.CloseWindow(WindowID.WindowID_Login);
			});
		}
		public static void ShowWindow(this DlgLoginComponent self, object context = null)
		{
			Debug.LogWarning("DlgLogin Show");
		}
		
		private static void OnLoginButton2ClickHandler(this DlgLoginComponent self)
		{
			var account = self.M_AccountTMP_InputField.text;
			var password = self.M_PasswordTMP_InputField.text;
			Debug.LogWarning($"account=>{account},password=>{password}");
			UIManager.Instance.ShowWindow(WindowID.WindowID_Test);
			UIManager.Instance.CloseWindow(WindowID.WindowID_Login);
		}
		private static void OnLoginButtonClickHandler(this DlgLoginComponent self)
		{
			var account = self.M_AccountTMP_InputField.text;
			var password = self.M_PasswordTMP_InputField.text;
			Debug.LogWarning($"account=>{account},password=>{password}");
			UIManager.Instance.ShowWindow(WindowID.WindowID_Red);
			UIManager.Instance.CloseWindow(WindowID.WindowID_Login);
		}
	}
}
