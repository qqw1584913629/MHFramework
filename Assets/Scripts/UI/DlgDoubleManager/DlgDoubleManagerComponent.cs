
using UnityEngine;
using UnityEngine.UI;
	public  class DlgDoubleManagerComponent : MonoBehaviour
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
		    		this.m_MG_CenterRectTransform = MUIHelepr.FindDeepChild<UnityEngine.RectTransform>(this.uiTransform.gameObject,"MG_Center");
     			}
     			return this.m_MG_CenterRectTransform;
     		}
     	}

		public TMPro.TMP_InputField M_SearchInputTMP_InputField
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_SearchInputTMP_InputField == null )
     			{
		    		this.m_M_SearchInputTMP_InputField = MUIHelepr.FindDeepChild<TMPro.TMP_InputField>(this.uiTransform.gameObject,"MG_Center/GameObject/M_SearchInput");
     			}
     			return this.m_M_SearchInputTMP_InputField;
     		}
     	}

		public UnityEngine.UI.Image M_SearchInputImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_SearchInputImage == null )
     			{
		    		this.m_M_SearchInputImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/M_SearchInput");
     			}
     			return this.m_M_SearchInputImage;
     		}
     	}

		public UnityEngine.UI.Button M_SearchButtonButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_SearchButtonButton == null )
     			{
		    		this.m_M_SearchButtonButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/M_SearchButton");
     			}
     			return this.m_M_SearchButtonButton;
     		}
     	}

		public UnityEngine.UI.Image M_SearchButtonImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_SearchButtonImage == null )
     			{
		    		this.m_M_SearchButtonImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/M_SearchButton");
     			}
     			return this.m_M_SearchButtonImage;
     		}
     	}

		public UnityEngine.UI.Button M_AddButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AddButton == null )
     			{
		    		this.m_M_AddButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Add");
     			}
     			return this.m_M_AddButton;
     		}
     	}

		public UnityEngine.UI.Image M_AddImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AddImage == null )
     			{
		    		this.m_M_AddImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Add");
     			}
     			return this.m_M_AddImage;
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
		    		this.m_M_CloseButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/M_Close");
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
		    		this.m_M_CloseImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/M_Close");
     			}
     			return this.m_M_CloseImage;
     		}
     	}

		public UnityEngine.RectTransform MG_ContentRectTransform
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_MG_ContentRectTransform == null )
     			{
		    		this.m_MG_ContentRectTransform = MUIHelepr.FindDeepChild<UnityEngine.RectTransform>(this.uiTransform.gameObject,"MG_Center/Center/Scroll View/Viewport/MG_Content");
     			}
     			return this.m_MG_ContentRectTransform;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_MG_MaskRectTransform = null;
			this.m_MG_CenterRectTransform = null;
			this.m_M_SearchInputTMP_InputField = null;
			this.m_M_SearchInputImage = null;
			this.m_M_SearchButtonButton = null;
			this.m_M_SearchButtonImage = null;
			this.m_M_AddButton = null;
			this.m_M_AddImage = null;
			this.m_M_CloseButton = null;
			this.m_M_CloseImage = null;
			this.m_MG_ContentRectTransform = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_MG_MaskRectTransform = null;
		private UnityEngine.RectTransform m_MG_CenterRectTransform = null;
		private TMPro.TMP_InputField m_M_SearchInputTMP_InputField = null;
		private UnityEngine.UI.Image m_M_SearchInputImage = null;
		private UnityEngine.UI.Button m_M_SearchButtonButton = null;
		private UnityEngine.UI.Image m_M_SearchButtonImage = null;
		private UnityEngine.UI.Button m_M_AddButton = null;
		private UnityEngine.UI.Image m_M_AddImage = null;
		private UnityEngine.UI.Button m_M_CloseButton = null;
		private UnityEngine.UI.Image m_M_CloseImage = null;
		private UnityEngine.RectTransform m_MG_ContentRectTransform = null;
		public Transform uiTransform = null;
	}
