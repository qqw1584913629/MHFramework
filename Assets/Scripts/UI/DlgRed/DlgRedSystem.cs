
using RedDotTutorial_1;
using UnityEngine;
using UnityEngine.UI;
public class DlgRedSystem : BasePanel
{
	private DlgRedComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgRedComponent>() == null)
			self = gameObject.AddComponent<DlgRedComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Fixed;
	}
	private void Start()
	{
		self.M_AddChild1Button.AddListener(OnAddRdChild1BtnClick);
		self.M_AddChild2Button.AddListener(OnAddRdChild2BtnClick);
		self.M_SubChild1Button.AddListener(OnReduceRdChild1BtnClick);
		self.M_SubChild2Button.AddListener(OnReduceRdChild2BtnClick);
	}
	public void OnAddRdChild1BtnClick()
	{
		int count = ManagerComponent.RedDotManager.GetRedDotCount(E_RedDotDefine.Child1);
		ManagerComponent.RedDotManager.Set(E_RedDotDefine.Child1, count + 1);
	}
	public void OnAddRdChild2BtnClick()
	{
		int count = ManagerComponent.RedDotManager.GetRedDotCount(E_RedDotDefine.Child2);
		ManagerComponent.RedDotManager.Set(E_RedDotDefine.Child2, count + 1);
	}
	public void OnReduceRdChild1BtnClick()
	{
		int count = ManagerComponent.RedDotManager.GetRedDotCount(E_RedDotDefine.Child1);
		ManagerComponent.RedDotManager.Set(E_RedDotDefine.Child1, count - 1);
	}
	public void OnReduceRdChild2BtnClick()
	{
		int count = ManagerComponent.RedDotManager.GetRedDotCount(E_RedDotDefine.Child2);
		ManagerComponent.RedDotManager.Set(E_RedDotDefine.Child2, count - 1);
	}
	public override void ShowWindow(string path)
	{
		base.ShowWindow(path);
		ManagerComponent.RedDotManager.AddRedDotNodeView(E_RedDotDefine.Test, self.M_RootImage.gameObject);
		ManagerComponent.RedDotManager.AddRedDotNodeView(E_RedDotDefine.Child1, self.M_Child1Image.gameObject);
		ManagerComponent.RedDotManager.AddRedDotNodeView(E_RedDotDefine.Child2, self.M_Child2Image.gameObject);
		
		
		ManagerComponent.RedDotManager.Set(E_RedDotDefine.Child2, 2);
		ManagerComponent.RedDotManager.Set(E_RedDotDefine.Child2, 0);

	}
	public override void HideWindow()
	{
		base.HideWindow();
		ManagerComponent.RedDotManager.SetRedDotNodeCallBack(E_RedDotDefine.Test, null);
		ManagerComponent.RedDotManager.SetRedDotNodeCallBack(E_RedDotDefine.Child1, null);
		ManagerComponent.RedDotManager.SetRedDotNodeCallBack(E_RedDotDefine.Child2, null);
	}
	public override void CloseWindow()
	{
		base.CloseWindow();
		ManagerComponent.RedDotManager.SetRedDotNodeCallBack(E_RedDotDefine.Test, null);
		ManagerComponent.RedDotManager.SetRedDotNodeCallBack(E_RedDotDefine.Child1, null);
		ManagerComponent.RedDotManager.SetRedDotNodeCallBack(E_RedDotDefine.Child2, null);
	}
}
