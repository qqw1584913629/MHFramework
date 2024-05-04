
using UnityEngine;
using UnityEngine.UI;
	public  class DlgClassQuestionComponent : MonoBehaviour
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

		public UnityEngine.UI.Button M_PreButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_PreButton == null )
     			{
		    		this.m_M_PreButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Pre");
     			}
     			return this.m_M_PreButton;
     		}
     	}

		public UnityEngine.UI.Image M_PreImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_PreImage == null )
     			{
		    		this.m_M_PreImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Pre");
     			}
     			return this.m_M_PreImage;
     		}
     	}

		public UnityEngine.UI.Button M_NextButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_NextButton == null )
     			{
		    		this.m_M_NextButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Next");
     			}
     			return this.m_M_NextButton;
     		}
     	}

		public UnityEngine.UI.Image M_NextImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_NextImage == null )
     			{
		    		this.m_M_NextImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Next");
     			}
     			return this.m_M_NextImage;
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

		public TMPro.TextMeshProUGUI M_QuestionTextMeshProUGUI
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_QuestionTextMeshProUGUI == null )
     			{
		    		this.m_M_QuestionTextMeshProUGUI = MUIHelepr.FindDeepChild<TMPro.TextMeshProUGUI>(this.uiTransform.gameObject,"MG_Center/GameObject (1)/M_Question");
     			}
     			return this.m_M_QuestionTextMeshProUGUI;
     		}
     	}

		public UnityEngine.RectTransform MG_OptionsRectTransform
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_MG_OptionsRectTransform == null )
     			{
		    		this.m_MG_OptionsRectTransform = MUIHelepr.FindDeepChild<UnityEngine.RectTransform>(this.uiTransform.gameObject,"MG_Center/MG_Options");
     			}
     			return this.m_MG_OptionsRectTransform;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_MG_MaskRectTransform = null;
			this.m_MG_CenterRectTransform = null;
			this.m_M_PreButton = null;
			this.m_M_PreImage = null;
			this.m_M_NextButton = null;
			this.m_M_NextImage = null;
			this.m_M_CloseButton = null;
			this.m_M_CloseImage = null;
			this.m_M_QuestionTextMeshProUGUI = null;
			this.m_MG_OptionsRectTransform = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_MG_MaskRectTransform = null;
		private UnityEngine.RectTransform m_MG_CenterRectTransform = null;
		private UnityEngine.UI.Button m_M_PreButton = null;
		private UnityEngine.UI.Image m_M_PreImage = null;
		private UnityEngine.UI.Button m_M_NextButton = null;
		private UnityEngine.UI.Image m_M_NextImage = null;
		private UnityEngine.UI.Button m_M_CloseButton = null;
		private UnityEngine.UI.Image m_M_CloseImage = null;
		private TMPro.TextMeshProUGUI m_M_QuestionTextMeshProUGUI = null;
		private UnityEngine.RectTransform m_MG_OptionsRectTransform = null;
		public Transform uiTransform = null;
	}
