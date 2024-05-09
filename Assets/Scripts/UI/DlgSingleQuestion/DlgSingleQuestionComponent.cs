
using UnityEngine;
using UnityEngine.UI;
	public  class DlgSingleQuestionComponent : MonoBehaviour
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

		public TMPro.TextMeshProUGUI M_TimeDownTextMeshProUGUI
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_TimeDownTextMeshProUGUI == null )
     			{
		    		this.m_M_TimeDownTextMeshProUGUI = MUIHelepr.FindDeepChild<TMPro.TextMeshProUGUI>(this.uiTransform.gameObject,"MG_Center/M_TimeDown");
     			}
     			return this.m_M_TimeDownTextMeshProUGUI;
     		}
     	}

		public UnityEngine.UI.Button M_Ans1Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Ans1Button == null )
     			{
		    		this.m_M_Ans1Button = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Ans1");
     			}
     			return this.m_M_Ans1Button;
     		}
     	}

		public UnityEngine.UI.Image M_Ans1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Ans1Image == null )
     			{
		    		this.m_M_Ans1Image = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Ans1");
     			}
     			return this.m_M_Ans1Image;
     		}
     	}

		public TMPro.TextMeshProUGUI M_Ans1TextTextMeshProUGUI
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Ans1TextTextMeshProUGUI == null )
     			{
		    		this.m_M_Ans1TextTextMeshProUGUI = MUIHelepr.FindDeepChild<TMPro.TextMeshProUGUI>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Ans1/M_Ans1Text");
     			}
     			return this.m_M_Ans1TextTextMeshProUGUI;
     		}
     	}

		public UnityEngine.UI.Button M_Ans2Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Ans2Button == null )
     			{
		    		this.m_M_Ans2Button = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Ans2");
     			}
     			return this.m_M_Ans2Button;
     		}
     	}

		public UnityEngine.UI.Image M_Ans2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Ans2Image == null )
     			{
		    		this.m_M_Ans2Image = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Ans2");
     			}
     			return this.m_M_Ans2Image;
     		}
     	}

		public TMPro.TextMeshProUGUI M_Ans2TextTextMeshProUGUI
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Ans2TextTextMeshProUGUI == null )
     			{
		    		this.m_M_Ans2TextTextMeshProUGUI = MUIHelepr.FindDeepChild<TMPro.TextMeshProUGUI>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Ans2/M_Ans2Text");
     			}
     			return this.m_M_Ans2TextTextMeshProUGUI;
     		}
     	}

		public UnityEngine.UI.Button M_Ans3Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Ans3Button == null )
     			{
		    		this.m_M_Ans3Button = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Ans3");
     			}
     			return this.m_M_Ans3Button;
     		}
     	}

		public UnityEngine.UI.Image M_Ans3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Ans3Image == null )
     			{
		    		this.m_M_Ans3Image = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Ans3");
     			}
     			return this.m_M_Ans3Image;
     		}
     	}

		public TMPro.TextMeshProUGUI M_Ans3TextTextMeshProUGUI
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Ans3TextTextMeshProUGUI == null )
     			{
		    		this.m_M_Ans3TextTextMeshProUGUI = MUIHelepr.FindDeepChild<TMPro.TextMeshProUGUI>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Ans3/M_Ans3Text");
     			}
     			return this.m_M_Ans3TextTextMeshProUGUI;
     		}
     	}

		public UnityEngine.UI.Button M_Ans4Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Ans4Button == null )
     			{
		    		this.m_M_Ans4Button = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Ans4");
     			}
     			return this.m_M_Ans4Button;
     		}
     	}

		public UnityEngine.UI.Image M_Ans4Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Ans4Image == null )
     			{
		    		this.m_M_Ans4Image = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Ans4");
     			}
     			return this.m_M_Ans4Image;
     		}
     	}

		public TMPro.TextMeshProUGUI M_Ans4TextTextMeshProUGUI
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Ans4TextTextMeshProUGUI == null )
     			{
		    		this.m_M_Ans4TextTextMeshProUGUI = MUIHelepr.FindDeepChild<TMPro.TextMeshProUGUI>(this.uiTransform.gameObject,"MG_Center/GameObject/M_Ans4/M_Ans4Text");
     			}
     			return this.m_M_Ans4TextTextMeshProUGUI;
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
			this.m_M_TimeDownTextMeshProUGUI = null;
			this.m_M_Ans1Button = null;
			this.m_M_Ans1Image = null;
			this.m_M_Ans1TextTextMeshProUGUI = null;
			this.m_M_Ans2Button = null;
			this.m_M_Ans2Image = null;
			this.m_M_Ans2TextTextMeshProUGUI = null;
			this.m_M_Ans3Button = null;
			this.m_M_Ans3Image = null;
			this.m_M_Ans3TextTextMeshProUGUI = null;
			this.m_M_Ans4Button = null;
			this.m_M_Ans4Image = null;
			this.m_M_Ans4TextTextMeshProUGUI = null;
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
		private TMPro.TextMeshProUGUI m_M_TimeDownTextMeshProUGUI = null;
		private UnityEngine.UI.Button m_M_Ans1Button = null;
		private UnityEngine.UI.Image m_M_Ans1Image = null;
		private TMPro.TextMeshProUGUI m_M_Ans1TextTextMeshProUGUI = null;
		private UnityEngine.UI.Button m_M_Ans2Button = null;
		private UnityEngine.UI.Image m_M_Ans2Image = null;
		private TMPro.TextMeshProUGUI m_M_Ans2TextTextMeshProUGUI = null;
		private UnityEngine.UI.Button m_M_Ans3Button = null;
		private UnityEngine.UI.Image m_M_Ans3Image = null;
		private TMPro.TextMeshProUGUI m_M_Ans3TextTextMeshProUGUI = null;
		private UnityEngine.UI.Button m_M_Ans4Button = null;
		private UnityEngine.UI.Image m_M_Ans4Image = null;
		private TMPro.TextMeshProUGUI m_M_Ans4TextTextMeshProUGUI = null;
		public Transform uiTransform = null;
	}
