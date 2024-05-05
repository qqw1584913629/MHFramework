
using UnityEngine;
using UnityEngine.UI;
	public  class DlgUserInfoComponent : MonoBehaviour
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

		public UnityEngine.RectTransform MG_CenterRectTransform
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_MG_CenterRectTransform == null )
     			{
		    		this.m_MG_CenterRectTransform = MUIHelepr.FindDeepChild<UnityEngine.RectTransform>(this.uiTransform.gameObject,"MG_Mask/MG_Center");
     			}
     			return this.m_MG_CenterRectTransform;
     		}
     	}

		public TMPro.TextMeshProUGUI M_AccountTextMeshProUGUI
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AccountTextMeshProUGUI == null )
     			{
		    		this.m_M_AccountTextMeshProUGUI = MUIHelepr.FindDeepChild<TMPro.TextMeshProUGUI>(this.uiTransform.gameObject,"MG_Mask/MG_Center/GameObject/Center/GameObject (1)/M_Account");
     			}
     			return this.m_M_AccountTextMeshProUGUI;
     		}
     	}

		public TMPro.TMP_InputField M_BeforePasswordTMP_InputField
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_BeforePasswordTMP_InputField == null )
     			{
		    		this.m_M_BeforePasswordTMP_InputField = MUIHelepr.FindDeepChild<TMPro.TMP_InputField>(this.uiTransform.gameObject,"MG_Mask/MG_Center/GameObject/Center/GameObject (2)/M_BeforePassword");
     			}
     			return this.m_M_BeforePasswordTMP_InputField;
     		}
     	}

		public UnityEngine.UI.Image M_BeforePasswordImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_BeforePasswordImage == null )
     			{
		    		this.m_M_BeforePasswordImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Mask/MG_Center/GameObject/Center/GameObject (2)/M_BeforePassword");
     			}
     			return this.m_M_BeforePasswordImage;
     		}
     	}

		public TMPro.TMP_InputField M_AfterPasswordTMP_InputField
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AfterPasswordTMP_InputField == null )
     			{
		    		this.m_M_AfterPasswordTMP_InputField = MUIHelepr.FindDeepChild<TMPro.TMP_InputField>(this.uiTransform.gameObject,"MG_Mask/MG_Center/GameObject/Center/GameObject (3)/M_AfterPassword");
     			}
     			return this.m_M_AfterPasswordTMP_InputField;
     		}
     	}

		public UnityEngine.UI.Image M_AfterPasswordImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AfterPasswordImage == null )
     			{
		    		this.m_M_AfterPasswordImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Mask/MG_Center/GameObject/Center/GameObject (3)/M_AfterPassword");
     			}
     			return this.m_M_AfterPasswordImage;
     		}
     	}

		public UnityEngine.UI.Button M_SaveButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_SaveButton == null )
     			{
		    		this.m_M_SaveButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Mask/MG_Center/GameObject/M_Save");
     			}
     			return this.m_M_SaveButton;
     		}
     	}

		public UnityEngine.UI.Image M_SaveImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_SaveImage == null )
     			{
		    		this.m_M_SaveImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Mask/MG_Center/GameObject/M_Save");
     			}
     			return this.m_M_SaveImage;
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
		    		this.m_M_CloseButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Mask/MG_Center/GameObject/M_Close");
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
		    		this.m_M_CloseImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Mask/MG_Center/GameObject/M_Close");
     			}
     			return this.m_M_CloseImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_MG_MaskRectTransform = null;
			this.m_MG_CenterRectTransform = null;
			this.m_M_AccountTextMeshProUGUI = null;
			this.m_M_BeforePasswordTMP_InputField = null;
			this.m_M_BeforePasswordImage = null;
			this.m_M_AfterPasswordTMP_InputField = null;
			this.m_M_AfterPasswordImage = null;
			this.m_M_SaveButton = null;
			this.m_M_SaveImage = null;
			this.m_M_CloseButton = null;
			this.m_M_CloseImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_MG_MaskRectTransform = null;
		private UnityEngine.RectTransform m_MG_CenterRectTransform = null;
		private TMPro.TextMeshProUGUI m_M_AccountTextMeshProUGUI = null;
		private TMPro.TMP_InputField m_M_BeforePasswordTMP_InputField = null;
		private UnityEngine.UI.Image m_M_BeforePasswordImage = null;
		private TMPro.TMP_InputField m_M_AfterPasswordTMP_InputField = null;
		private UnityEngine.UI.Image m_M_AfterPasswordImage = null;
		private UnityEngine.UI.Button m_M_SaveButton = null;
		private UnityEngine.UI.Image m_M_SaveImage = null;
		private UnityEngine.UI.Button m_M_CloseButton = null;
		private UnityEngine.UI.Image m_M_CloseImage = null;
		public Transform uiTransform = null;
	}
