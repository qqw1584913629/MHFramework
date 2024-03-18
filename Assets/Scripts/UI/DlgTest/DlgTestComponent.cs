
using UnityEngine;
using UnityEngine.UI;
	public  class DlgTestComponent : MonoBehaviour, IUILogic
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

		public UnityEngine.UI.Image M_LoopScrollList_Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_LoopScrollList_Image == null )
     			{
		    		this.m_M_LoopScrollList_Image = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Mask/M_LoopScrollList_");
     			}
     			return this.m_M_LoopScrollList_Image;
     		}
     	}

		public MHLoopEnhancedScroller M_LoopScrollList_MHLoopEnhancedScroller
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_LoopScrollList_MHLoopEnhancedScroller == null )
     			{
		    		this.m_M_LoopScrollList_MHLoopEnhancedScroller = MUIHelepr.FindDeepChild<MHLoopEnhancedScroller>(this.uiTransform.gameObject,"MG_Mask/M_LoopScrollList_");
     			}
     			return this.m_M_LoopScrollList_MHLoopEnhancedScroller;
     		}
     	}

		public UnityEngine.UI.InputField M_AccountInputField
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AccountInputField == null )
     			{
		    		this.m_M_AccountInputField = MUIHelepr.FindDeepChild<UnityEngine.UI.InputField>(this.uiTransform.gameObject,"M_Account");
     			}
     			return this.m_M_AccountInputField;
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
		    		this.m_M_AccountImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"M_Account");
     			}
     			return this.m_M_AccountImage;
     		}
     	}

		public UnityEngine.UI.InputField M_PasswordInputField
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_PasswordInputField == null )
     			{
		    		this.m_M_PasswordInputField = MUIHelepr.FindDeepChild<UnityEngine.UI.InputField>(this.uiTransform.gameObject,"M_Password");
     			}
     			return this.m_M_PasswordInputField;
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
		    		this.m_M_PasswordImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"M_Password");
     			}
     			return this.m_M_PasswordImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_MG_MaskRectTransform = null;
			this.m_M_LoopScrollList_Image = null;
			this.m_M_LoopScrollList_MHLoopEnhancedScroller = null;
			this.m_M_AccountInputField = null;
			this.m_M_AccountImage = null;
			this.m_M_PasswordInputField = null;
			this.m_M_PasswordImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_MG_MaskRectTransform = null;
		private UnityEngine.UI.Image m_M_LoopScrollList_Image = null;
		private MHLoopEnhancedScroller m_M_LoopScrollList_MHLoopEnhancedScroller = null;
		private UnityEngine.UI.InputField m_M_AccountInputField = null;
		private UnityEngine.UI.Image m_M_AccountImage = null;
		private UnityEngine.UI.InputField m_M_PasswordInputField = null;
		private UnityEngine.UI.Image m_M_PasswordImage = null;
		public Transform uiTransform = null;
	}
