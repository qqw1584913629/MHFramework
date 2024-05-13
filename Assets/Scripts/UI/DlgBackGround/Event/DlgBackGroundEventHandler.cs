using System;
namespace MH
{
	[AUIEvent(WindowID.WindowID_BackGround)]
	public  class DlgBackGroundEventHandler : IAUIEventHandler
	{

		public void OnInitWindowCoreData(BasePanel basePanel)
		{
			basePanel.windowType = UIWindowType.Normal; 
			basePanel.uiLogic = Activator.CreateInstance(typeof(DlgBackGroundComponent)) as DlgBackGroundComponent; 
			if (basePanel.uiLogic is DlgBackGroundComponent basePanelUILogic) basePanelUILogic.uiTransform = basePanel.obj.transform; 
		}

		public void OnRegisterUIEvent(BasePanel basePanel)
		{
			if (basePanel.uiLogic is DlgBackGroundComponent basePanelUILogic) basePanelUILogic.RegisterUIEvent(); 
		}

		public void OnShowWindow(BasePanel basePanel, object contextData = null)
		{
			if (basePanel.uiLogic is DlgBackGroundComponent basePanelUILogic) basePanelUILogic.ShowWindow(contextData); 
		}

		public void OnHideWindow(BasePanel basePanel)
		{
		}

		public void BeforeUnload(BasePanel basePanel)
		{
		}

	}
}
