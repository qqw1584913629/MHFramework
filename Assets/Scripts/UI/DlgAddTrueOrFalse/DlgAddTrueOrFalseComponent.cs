
using UnityEngine;
using UnityEngine.UI;
	public  class DlgAddTrueOrFalseComponent : MonoBehaviour
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

		public TMPro.TMP_InputField M_QuestionTMP_InputField
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_QuestionTMP_InputField == null )
     			{
		    		this.m_M_QuestionTMP_InputField = MUIHelepr.FindDeepChild<TMPro.TMP_InputField>(this.uiTransform.gameObject,"MG_Mask/MG_Center/GameObject/Center/GameObject/M_Question");
     			}
     			return this.m_M_QuestionTMP_InputField;
     		}
     	}

		public UnityEngine.UI.Image M_QuestionImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_QuestionImage == null )
     			{
		    		this.m_M_QuestionImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Mask/MG_Center/GameObject/Center/GameObject/M_Question");
     			}
     			return this.m_M_QuestionImage;
     		}
     	}

		public TMPro.TMP_InputField M_TrueAnsTMP_InputField
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_TrueAnsTMP_InputField == null )
     			{
		    		this.m_M_TrueAnsTMP_InputField = MUIHelepr.FindDeepChild<TMPro.TMP_InputField>(this.uiTransform.gameObject,"MG_Mask/MG_Center/GameObject/Center/GameObject (1)/M_TrueAns");
     			}
     			return this.m_M_TrueAnsTMP_InputField;
     		}
     	}

		public UnityEngine.UI.Image M_TrueAnsImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_TrueAnsImage == null )
     			{
		    		this.m_M_TrueAnsImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Mask/MG_Center/GameObject/Center/GameObject (1)/M_TrueAns");
     			}
     			return this.m_M_TrueAnsImage;
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
			this.m_M_QuestionTMP_InputField = null;
			this.m_M_QuestionImage = null;
			this.m_M_TrueAnsTMP_InputField = null;
			this.m_M_TrueAnsImage = null;
			this.m_M_SaveButton = null;
			this.m_M_SaveImage = null;
			this.m_M_CloseButton = null;
			this.m_M_CloseImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_MG_MaskRectTransform = null;
		private UnityEngine.RectTransform m_MG_CenterRectTransform = null;
		private TMPro.TMP_InputField m_M_QuestionTMP_InputField = null;
		private UnityEngine.UI.Image m_M_QuestionImage = null;
		private TMPro.TMP_InputField m_M_TrueAnsTMP_InputField = null;
		private UnityEngine.UI.Image m_M_TrueAnsImage = null;
		private UnityEngine.UI.Button m_M_SaveButton = null;
		private UnityEngine.UI.Image m_M_SaveImage = null;
		private UnityEngine.UI.Button m_M_CloseButton = null;
		private UnityEngine.UI.Image m_M_CloseImage = null;
		public Transform uiTransform = null;
	}
