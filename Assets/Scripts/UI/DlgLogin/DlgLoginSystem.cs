
using UnityEngine;
using UnityEngine.UI;
public class DlgLoginSystem : BasePanel
{
	private DlgLoginComponent self;
	private void Awake()
	{
		if (gameObject.GetComponent<DlgLoginComponent>() == null)
			self = gameObject.AddComponent<DlgLoginComponent>();
		self.uiTransform = transform;
		windowType = UIWindowType.Fixed;
	}
	private void Start()
	{
		self.M_LoginButtonButton.AddListener(OnLoginButtonClickHandler);
		self.M_CloseButton.AddListener(() =>
		{
			UIManager.Instance.CloseWindow(WindowID.WindowID_Login);
		});
	}

	private void OnLoginButtonClickHandler()
	{
		var account = self.M_AccountTMP_InputField.text;
		var password = self.M_PasswordTMP_InputField.text;
		Debug.LogWarning($"account=>{account},password=>{password}");
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
