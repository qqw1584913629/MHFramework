using System;
namespace MH
{
	[AUIEvent(WindowID.WindowID_Red)]
	public  class DlgRedEventHandler : IAUIEventHandler	{
		public void OnInitWindowCoreData(BasePanel basePanel)
		{
			basePanel.windowType = UIWindowType.Normal;
			basePanel.uiLogic = Activator.CreateInstance(typeof(DlgRedComponent)) as DlgRedComponent;
			if (basePanel.uiLogic is DlgRedComponent basePanelUILogic) basePanelUILogic.uiTransform = basePanel.obj.transform;
		}

		public void OnRegisterUIEvent(BasePanel basePanel)
		{
			if (basePanel.uiLogic is DlgRedComponent basePanelUILogic) basePanelUILogic.RegisterUIEvent();
		}

		public void OnShowWindow(BasePanel basePanel, object contextData = null)
		{
			if (basePanel.uiLogic is DlgRedComponent basePanelUILogic) basePanelUILogic.ShowWindow(contextData);
		}

		public void OnHideWindow(BasePanel basePanel)
		{
			if (basePanel.uiLogic is DlgRedComponent basePanelUILogic) basePanelUILogic.OnHideWindow();
		}

		public void BeforeUnload(BasePanel basePanel)
		{
		}

	}
}
