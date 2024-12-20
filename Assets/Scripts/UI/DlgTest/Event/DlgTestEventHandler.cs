using System;
using UnityEngine;

[AUIEvent(WindowID.WindowID_Test)]
public class DlgTestEventHandler : IAUIEventHandler
{
    public void OnInitWindowCoreData(BasePanel basePanel)
    {
        basePanel.windowType = UIWindowType.Normal;
        basePanel.uiLogic = Activator.CreateInstance(typeof(DlgTestComponent)) as DlgTestComponent;
        if (basePanel.uiLogic is DlgTestComponent basePanelUILogic) basePanelUILogic.uiTransform = basePanel.obj.transform;
    }

    public void OnRegisterUIEvent(BasePanel basePanel)
    {
        if (basePanel.uiLogic is DlgTestComponent basePanelUILogic) basePanelUILogic.RegisterUIEvent();
    }

    public void OnShowWindow(BasePanel basePanel, object contextData = null)
    {
        if (basePanel.uiLogic is DlgTestComponent basePanelUILogic) basePanelUILogic.ShowWindow(contextData);
    }

    public void OnHideWindow(BasePanel basePanel)
    {
    }

    public void BeforeUnload(BasePanel basePanel)
    {
    }
}