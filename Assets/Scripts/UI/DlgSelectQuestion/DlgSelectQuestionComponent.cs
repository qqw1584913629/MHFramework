
using UnityEngine;
using UnityEngine.UI;
	public  class DlgSelectQuestionComponent : MonoBehaviour
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

		public UnityEngine.UI.Button M_SingleButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_SingleButton == null )
     			{
		    		this.m_M_SingleButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Single");
     			}
     			return this.m_M_SingleButton;
     		}
     	}

		public UnityEngine.UI.Image M_SingleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_SingleImage == null )
     			{
		    		this.m_M_SingleImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Single");
     			}
     			return this.m_M_SingleImage;
     		}
     	}

		public UnityEngine.UI.Button M_TrueOrFalseButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_TrueOrFalseButton == null )
     			{
		    		this.m_M_TrueOrFalseButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/M_TrueOrFalse");
     			}
     			return this.m_M_TrueOrFalseButton;
     		}
     	}

		public UnityEngine.UI.Image M_TrueOrFalseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_TrueOrFalseImage == null )
     			{
		    		this.m_M_TrueOrFalseImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/M_TrueOrFalse");
     			}
     			return this.m_M_TrueOrFalseImage;
     		}
     	}

		public UnityEngine.UI.Button M_DoubleButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_DoubleButton == null )
     			{
		    		this.m_M_DoubleButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Double");
     			}
     			return this.m_M_DoubleButton;
     		}
     	}

		public UnityEngine.UI.Image M_DoubleImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_DoubleImage == null )
     			{
		    		this.m_M_DoubleImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Double");
     			}
     			return this.m_M_DoubleImage;
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

		public void DestroyWidget()
		{
			this.m_MG_MaskRectTransform = null;
			this.m_MG_CenterRectTransform = null;
			this.m_M_SingleButton = null;
			this.m_M_SingleImage = null;
			this.m_M_TrueOrFalseButton = null;
			this.m_M_TrueOrFalseImage = null;
			this.m_M_DoubleButton = null;
			this.m_M_DoubleImage = null;
			this.m_M_CloseButton = null;
			this.m_M_CloseImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_MG_MaskRectTransform = null;
		private UnityEngine.RectTransform m_MG_CenterRectTransform = null;
		private UnityEngine.UI.Button m_M_SingleButton = null;
		private UnityEngine.UI.Image m_M_SingleImage = null;
		private UnityEngine.UI.Button m_M_TrueOrFalseButton = null;
		private UnityEngine.UI.Image m_M_TrueOrFalseImage = null;
		private UnityEngine.UI.Button m_M_DoubleButton = null;
		private UnityEngine.UI.Image m_M_DoubleImage = null;
		private UnityEngine.UI.Button m_M_CloseButton = null;
		private UnityEngine.UI.Image m_M_CloseImage = null;
		public Transform uiTransform = null;
	}
