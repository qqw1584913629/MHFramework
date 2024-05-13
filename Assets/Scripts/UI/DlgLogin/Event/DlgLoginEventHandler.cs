using System;
namespace MH
{
	[AUIEvent(WindowID.WindowID_Login)]
	public  class DlgLoginEventHandler : IAUIEventHandler
	{
		public void OnInitWindowCoreData(BasePanel basePanel)
		{ 
			basePanel.windowType = UIWindowType.Normal; 
			basePanel.uiLogic = Activator.CreateInstance(typeof(DlgLoginComponent)) as DlgLoginComponent; 
			if (basePanel.uiLogic is DlgLoginComponent basePanelUILogic) basePanelUILogic.uiTransform = basePanel.obj.transform; 
		}

		public void OnRegisterUIEvent(BasePanel basePanel)
		{
			if (basePanel.uiLogic is DlgLoginComponent basePanelUILogic) basePanelUILogic.RegisterUIEvent(); 
		}

		public void OnShowWindow(BasePanel basePanel, object contextData = null)
		{
			if (basePanel.uiLogic is DlgLoginComponent basePanelUILogic) basePanelUILogic.ShowWindow(contextData); 
		}

		public void OnHideWindow(BasePanel basePanel)
		{
		}

		public void BeforeUnload(BasePanel basePanel)
		{
		}

	}
}
