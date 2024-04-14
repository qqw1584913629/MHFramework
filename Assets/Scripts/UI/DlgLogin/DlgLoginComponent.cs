
using UnityEngine;
using UnityEngine.UI;
	public  class DlgLoginComponent : MonoBehaviour
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

		public UnityEngine.UI.Button M_RoleButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_RoleButton == null )
     			{
		    		this.m_M_RoleButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/GameObject/GameObject/M_Role");
     			}
     			return this.m_M_RoleButton;
     		}
     	}

		public UnityEngine.UI.Image M_RoleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_RoleImage == null )
     			{
		    		this.m_M_RoleImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/GameObject/GameObject/M_Role");
     			}
     			return this.m_M_RoleImage;
     		}
     	}

		public UnityEngine.UI.Button M_NormalButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_NormalButton == null )
     			{
		    		this.m_M_NormalButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/GameObject/GameObject/M_Normal");
     			}
     			return this.m_M_NormalButton;
     		}
     	}

		public UnityEngine.UI.Image M_NormalImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_NormalImage == null )
     			{
		    		this.m_M_NormalImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/GameObject/GameObject/M_Normal");
     			}
     			return this.m_M_NormalImage;
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
		    		this.m_M_AccountTMP_InputField = MUIHelepr.FindDeepChild<TMPro.TMP_InputField>(this.uiTransform.gameObject,"Center/GameObject/GameObject (1)/M_Account");
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
		    		this.m_M_AccountImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/GameObject/GameObject (1)/M_Account");
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
		    		this.m_M_PasswordTMP_InputField = MUIHelepr.FindDeepChild<TMPro.TMP_InputField>(this.uiTransform.gameObject,"Center/GameObject/GameObject (2)/M_Password");
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
		    		this.m_M_PasswordImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/GameObject/GameObject (2)/M_Password");
     			}
     			return this.m_M_PasswordImage;
     		}
     	}

		public UnityEngine.UI.Button M_RegisterButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_RegisterButton == null )
     			{
		    		this.m_M_RegisterButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/GameObject/GameObject (3)/M_Register");
     			}
     			return this.m_M_RegisterButton;
     		}
     	}

		public UnityEngine.UI.Image M_RegisterImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_RegisterImage == null )
     			{
		    		this.m_M_RegisterImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/GameObject/GameObject (3)/M_Register");
     			}
     			return this.m_M_RegisterImage;
     		}
     	}

		public UnityEngine.UI.Button M_LoginButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_LoginButton == null )
     			{
		    		this.m_M_LoginButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/GameObject/GameObject (3)/M_Login");
     			}
     			return this.m_M_LoginButton;
     		}
     	}

		public UnityEngine.UI.Image M_LoginImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_LoginImage == null )
     			{
		    		this.m_M_LoginImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/GameObject/GameObject (3)/M_Login");
     			}
     			return this.m_M_LoginImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_MG_MaskRectTransform = null;
			this.m_M_RoleButton = null;
			this.m_M_RoleImage = null;
			this.m_M_NormalButton = null;
			this.m_M_NormalImage = null;
			this.m_M_AccountTMP_InputField = null;
			this.m_M_AccountImage = null;
			this.m_M_PasswordTMP_InputField = null;
			this.m_M_PasswordImage = null;
			this.m_M_RegisterButton = null;
			this.m_M_RegisterImage = null;
			this.m_M_LoginButton = null;
			this.m_M_LoginImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_MG_MaskRectTransform = null;
		private UnityEngine.UI.Button m_M_RoleButton = null;
		private UnityEngine.UI.Image m_M_RoleImage = null;
		private UnityEngine.UI.Button m_M_NormalButton = null;
		private UnityEngine.UI.Image m_M_NormalImage = null;
		private TMPro.TMP_InputField m_M_AccountTMP_InputField = null;
		private UnityEngine.UI.Image m_M_AccountImage = null;
		private TMPro.TMP_InputField m_M_PasswordTMP_InputField = null;
		private UnityEngine.UI.Image m_M_PasswordImage = null;
		private UnityEngine.UI.Button m_M_RegisterButton = null;
		private UnityEngine.UI.Image m_M_RegisterImage = null;
		private UnityEngine.UI.Button m_M_LoginButton = null;
		private UnityEngine.UI.Image m_M_LoginImage = null;
		public Transform uiTransform = null;
	}
