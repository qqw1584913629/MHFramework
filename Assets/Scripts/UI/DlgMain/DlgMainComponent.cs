
using UnityEngine;
using UnityEngine.UI;
	public  class DlgMainComponent : MonoBehaviour
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

		public UnityEngine.UI.Button M_StudioButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_StudioButton == null )
     			{
		    		this.m_M_StudioButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/Center/M_Studio");
     			}
     			return this.m_M_StudioButton;
     		}
     	}

		public UnityEngine.UI.Image M_StudioImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_StudioImage == null )
     			{
		    		this.m_M_StudioImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/Center/M_Studio");
     			}
     			return this.m_M_StudioImage;
     		}
     	}

		public UnityEngine.UI.Button M_QuestionButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_QuestionButton == null )
     			{
		    		this.m_M_QuestionButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/Center/M_Question");
     			}
     			return this.m_M_QuestionButton;
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
		    		this.m_M_QuestionImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/Center/M_Question");
     			}
     			return this.m_M_QuestionImage;
     		}
     	}

		public UnityEngine.UI.Button M_ScoreCountButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_ScoreCountButton == null )
     			{
		    		this.m_M_ScoreCountButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/Center/M_ScoreCount");
     			}
     			return this.m_M_ScoreCountButton;
     		}
     	}

		public UnityEngine.UI.Image M_ScoreCountImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_ScoreCountImage == null )
     			{
		    		this.m_M_ScoreCountImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/Center/M_ScoreCount");
     			}
     			return this.m_M_ScoreCountImage;
     		}
     	}

		public UnityEngine.UI.Button M_AdminButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AdminButton == null )
     			{
		    		this.m_M_AdminButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/Manager/M_Admin");
     			}
     			return this.m_M_AdminButton;
     		}
     	}

		public UnityEngine.UI.Image M_AdminImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AdminImage == null )
     			{
		    		this.m_M_AdminImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/Manager/M_Admin");
     			}
     			return this.m_M_AdminImage;
     		}
     	}

		public UnityEngine.UI.Button M_UserInfoButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_UserInfoButton == null )
     			{
		    		this.m_M_UserInfoButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/Manager/M_UserInfo");
     			}
     			return this.m_M_UserInfoButton;
     		}
     	}

		public UnityEngine.UI.Image M_UserInfoImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_UserInfoImage == null )
     			{
		    		this.m_M_UserInfoImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/Manager/M_UserInfo");
     			}
     			return this.m_M_UserInfoImage;
     		}
     	}

		public UnityEngine.UI.Button M_QuitButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_QuitButton == null )
     			{
		    		this.m_M_QuitButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/Manager/M_Quit");
     			}
     			return this.m_M_QuitButton;
     		}
     	}

		public UnityEngine.UI.Image M_QuitImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_QuitImage == null )
     			{
		    		this.m_M_QuitImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/Manager/M_Quit");
     			}
     			return this.m_M_QuitImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_MG_MaskRectTransform = null;
			this.m_MG_CenterRectTransform = null;
			this.m_M_StudioButton = null;
			this.m_M_StudioImage = null;
			this.m_M_QuestionButton = null;
			this.m_M_QuestionImage = null;
			this.m_M_ScoreCountButton = null;
			this.m_M_ScoreCountImage = null;
			this.m_M_AdminButton = null;
			this.m_M_AdminImage = null;
			this.m_M_UserInfoButton = null;
			this.m_M_UserInfoImage = null;
			this.m_M_QuitButton = null;
			this.m_M_QuitImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_MG_MaskRectTransform = null;
		private UnityEngine.RectTransform m_MG_CenterRectTransform = null;
		private UnityEngine.UI.Button m_M_StudioButton = null;
		private UnityEngine.UI.Image m_M_StudioImage = null;
		private UnityEngine.UI.Button m_M_QuestionButton = null;
		private UnityEngine.UI.Image m_M_QuestionImage = null;
		private UnityEngine.UI.Button m_M_ScoreCountButton = null;
		private UnityEngine.UI.Image m_M_ScoreCountImage = null;
		private UnityEngine.UI.Button m_M_AdminButton = null;
		private UnityEngine.UI.Image m_M_AdminImage = null;
		private UnityEngine.UI.Button m_M_UserInfoButton = null;
		private UnityEngine.UI.Image m_M_UserInfoImage = null;
		private UnityEngine.UI.Button m_M_QuitButton = null;
		private UnityEngine.UI.Image m_M_QuitImage = null;
		public Transform uiTransform = null;
	}
