
using RedDotTutorial_1;
using UnityEngine;
using UnityEngine.UI;
namespace MH
{
	public static class DlgRedSystem 
	{
		public static void RegisterUIEvent(this DlgRedComponent self)
		{
			self.M_CloseButton.AddListener(() =>
			{
				UIManager.Instance.ShowWindow(WindowID.WindowID_Login);
				UIManager.Instance.HideWindow(WindowID.WindowID_Red);
			});
			self.M_AddChild1Button.AddListener(self.OnAddRdChild1BtnClick);
			self.M_SubChild1Button.AddListener(self.OnReduceRdChild1BtnClick);
			self.M_AddChild3Button.AddListener(self.OnAddRdChild3BtnClick);
			self.M_SubChild3Button.AddListener(self.OnReduceRdChild3BtnClick);
		}
		public static void ShowWindow(this DlgRedComponent self, object context = null)
		{
			ManagerComponent.RedDotManager.AddRedDotNodeView(E_RedDotDefine.Test, self.M_RootImage.gameObject);
			ManagerComponent.RedDotManager.AddRedDotNodeView(E_RedDotDefine.Child1, self.M_Child1Image.gameObject);
			ManagerComponent.RedDotManager.AddRedDotNodeView(E_RedDotDefine.Child2, self.M_Child2Image.gameObject);
			ManagerComponent.RedDotManager.AddRedDotNodeView(E_RedDotDefine.Child3, self.M_Child3Image.gameObject);
			ManagerComponent.RedDotManager.Set(E_RedDotDefine.Child1, 2);
			ManagerComponent.RedDotManager.Set(E_RedDotDefine.Child3, 2);
		}
		private static void OnAddRdChild3BtnClick(this DlgRedComponent self)
		{
			int count = ManagerComponent.RedDotManager.GetRedDotCount(E_RedDotDefine.Child3);
			ManagerComponent.RedDotManager.Set(E_RedDotDefine.Child3, count + 1);
		}

		public static void OnAddRdChild1BtnClick(this DlgRedComponent self)
		{
			int count = ManagerComponent.RedDotManager.GetRedDotCount(E_RedDotDefine.Child1);
			ManagerComponent.RedDotManager.Set(E_RedDotDefine.Child1, count + 1);
		}
		public static void OnReduceRdChild1BtnClick(this DlgRedComponent self)
		{
			int count = ManagerComponent.RedDotManager.GetRedDotCount(E_RedDotDefine.Child1);
			ManagerComponent.RedDotManager.Set(E_RedDotDefine.Child1, count - 1);
		}
		public static void OnReduceRdChild3BtnClick(this DlgRedComponent self)
		{
			int count = ManagerComponent.RedDotManager.GetRedDotCount(E_RedDotDefine.Child3);
			ManagerComponent.RedDotManager.Set(E_RedDotDefine.Child3, count - 1);
		}

		public static void OnHideWindow(this DlgRedComponent self)
		{
			ManagerComponent.RedDotManager.SetRedDotNodeCallBack(E_RedDotDefine.Test, null);
			ManagerComponent.RedDotManager.SetRedDotNodeCallBack(E_RedDotDefine.Child1, null);
			ManagerComponent.RedDotManager.SetRedDotNodeCallBack(E_RedDotDefine.Child2, null);
			ManagerComponent.RedDotManager.SetRedDotNodeCallBack(E_RedDotDefine.Child3, null);
			
			
			Debug.LogWarning("hide..");
		}

	}
}
