
using UnityEngine;
using UnityEngine.UI;
namespace MH
{
	public static class DlgBackGroundSystem 
	{
		public static void RegisterUIEvent(this DlgBackGroundComponent self)
		{
			self.MLoginButton.AddListener(() =>
			{
				UIManager.Instance.ShowWindow(WindowID.WindowID_Login);
				UIManager.Instance.HideWindow(WindowID.WindowID_BackGround);
			});
		}
		public static void ShowWindow(this DlgBackGroundComponent self, object context = null)
		{
			Debug.LogWarning("DlgBackGround Show");
		}
	}
}
