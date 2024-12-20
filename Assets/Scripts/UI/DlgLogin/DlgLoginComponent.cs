
using UnityEngine;
using UnityEngine.UI;
namespace MH
{
	public class DlgLoginComponent : BasePanel, IUILogic
	{
		public UnityEngine.RectTransform MG_MaskRectTransform
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_MG_MaskRectTransform == null )
     			{
		    		this.m_MG_MaskRectTransform = MUIHelepr.FindDeepChild<UnityEngine.RectTransform>(this.uiTransform.gameObject,"MG_Mask");
     			}
     			return this.m_MG_MaskRectTransform;
     		}
     	}

		public UnityEngine.UI.Button M_CloseButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_CloseButton == null )
     			{
		    		this.m_M_CloseButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"M_Close");
     			}
     			return this.m_M_CloseButton;
     		}
     	}

		public UnityEngine.UI.Image M_CloseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_CloseImage == null )
     			{
		    		this.m_M_CloseImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"M_Close");
     			}
     			return this.m_M_CloseImage;
     		}
     	}

		public TMPro.TMP_InputField M_AccountTMP_InputField
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AccountTMP_InputField == null )
     			{
		    		this.m_M_AccountTMP_InputField = MUIHelepr.FindDeepChild<TMPro.TMP_InputField>(this.uiTransform.gameObject,"Center/M_Account");
     			}
     			return this.m_M_AccountTMP_InputField;
     		}
     	}

		public UnityEngine.UI.Image M_AccountImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AccountImage == null )
     			{
		    		this.m_M_AccountImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/M_Account");
     			}
     			return this.m_M_AccountImage;
     		}
     	}

		public TMPro.TMP_InputField M_PasswordTMP_InputField
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_PasswordTMP_InputField == null )
     			{
		    		this.m_M_PasswordTMP_InputField = MUIHelepr.FindDeepChild<TMPro.TMP_InputField>(this.uiTransform.gameObject,"Center/M_Password");
     			}
     			return this.m_M_PasswordTMP_InputField;
     		}
     	}

		public UnityEngine.UI.Image M_PasswordImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_PasswordImage == null )
     			{
		    		this.m_M_PasswordImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/M_Password");
     			}
     			return this.m_M_PasswordImage;
     		}
     	}

		public UnityEngine.UI.Button M_LoginButtonButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_LoginButtonButton == null )
     			{
		    		this.m_M_LoginButtonButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/M_LoginButton");
     			}
     			return this.m_M_LoginButtonButton;
     		}
     	}

		public UnityEngine.UI.Image M_LoginButtonImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_LoginButtonImage == null )
     			{
		    		this.m_M_LoginButtonImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/M_LoginButton");
     			}
     			return this.m_M_LoginButtonImage;
     		}
     	}

		public UnityEngine.UI.Button M_LoginButton2Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_LoginButton2Button == null )
     			{
		    		this.m_M_LoginButton2Button = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/M_LoginButton2");
     			}
     			return this.m_M_LoginButton2Button;
     		}
     	}

		public UnityEngine.UI.Image M_LoginButton2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_LoginButton2Image == null )
     			{
		    		this.m_M_LoginButton2Image = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/M_LoginButton2");
     			}
     			return this.m_M_LoginButton2Image;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_MG_MaskRectTransform = null;
			this.m_M_CloseButton = null;
			this.m_M_CloseImage = null;
			this.m_M_AccountTMP_InputField = null;
			this.m_M_AccountImage = null;
			this.m_M_PasswordTMP_InputField = null;
			this.m_M_PasswordImage = null;
			this.m_M_LoginButtonButton = null;
			this.m_M_LoginButtonImage = null;
			this.m_M_LoginButton2Button = null;
			this.m_M_LoginButton2Image = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_MG_MaskRectTransform = null;
		private UnityEngine.UI.Button m_M_CloseButton = null;
		private UnityEngine.UI.Image m_M_CloseImage = null;
		private TMPro.TMP_InputField m_M_AccountTMP_InputField = null;
		private UnityEngine.UI.Image m_M_AccountImage = null;
		private TMPro.TMP_InputField m_M_PasswordTMP_InputField = null;
		private UnityEngine.UI.Image m_M_PasswordImage = null;
		private UnityEngine.UI.Button m_M_LoginButtonButton = null;
		private UnityEngine.UI.Image m_M_LoginButtonImage = null;
		private UnityEngine.UI.Button m_M_LoginButton2Button = null;
		private UnityEngine.UI.Image m_M_LoginButton2Image = null;
		public Transform uiTransform = null;
	}
}
