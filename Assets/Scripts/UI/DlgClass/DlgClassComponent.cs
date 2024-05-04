
using UnityEngine;
using UnityEngine.UI;
	public  class DlgClassComponent : MonoBehaviour
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

		public UnityEngine.UI.Button M_BaseButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_BaseButton == null )
     			{
		    		this.m_M_BaseButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/Center/GameObject/M_Base");
     			}
     			return this.m_M_BaseButton;
     		}
     	}

		public UnityEngine.UI.Image M_BaseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_BaseImage == null )
     			{
		    		this.m_M_BaseImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/Center/GameObject/M_Base");
     			}
     			return this.m_M_BaseImage;
     		}
     	}

		public UnityEngine.UI.Button M_AttackButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AttackButton == null )
     			{
		    		this.m_M_AttackButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/Center/GameObject/M_Attack");
     			}
     			return this.m_M_AttackButton;
     		}
     	}

		public UnityEngine.UI.Image M_AttackImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AttackImage == null )
     			{
		    		this.m_M_AttackImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/Center/GameObject/M_Attack");
     			}
     			return this.m_M_AttackImage;
     		}
     	}

		public UnityEngine.UI.Button M_DefenseButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_DefenseButton == null )
     			{
		    		this.m_M_DefenseButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/Center/GameObject (1)/M_Defense");
     			}
     			return this.m_M_DefenseButton;
     		}
     	}

		public UnityEngine.UI.Image M_DefenseImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_DefenseImage == null )
     			{
		    		this.m_M_DefenseImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/Center/GameObject (1)/M_Defense");
     			}
     			return this.m_M_DefenseImage;
     		}
     	}

		public UnityEngine.UI.Button M_ActButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_ActButton == null )
     			{
		    		this.m_M_ActButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"MG_Center/GameObject/Center/GameObject (1)/M_Act");
     			}
     			return this.m_M_ActButton;
     		}
     	}

		public UnityEngine.UI.Image M_ActImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_ActImage == null )
     			{
		    		this.m_M_ActImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"MG_Center/GameObject/Center/GameObject (1)/M_Act");
     			}
     			return this.m_M_ActImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_MG_MaskRectTransform = null;
			this.m_MG_CenterRectTransform = null;
			this.m_M_BaseButton = null;
			this.m_M_BaseImage = null;
			this.m_M_AttackButton = null;
			this.m_M_AttackImage = null;
			this.m_M_DefenseButton = null;
			this.m_M_DefenseImage = null;
			this.m_M_ActButton = null;
			this.m_M_ActImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_MG_MaskRectTransform = null;
		private UnityEngine.RectTransform m_MG_CenterRectTransform = null;
		private UnityEngine.UI.Button m_M_BaseButton = null;
		private UnityEngine.UI.Image m_M_BaseImage = null;
		private UnityEngine.UI.Button m_M_AttackButton = null;
		private UnityEngine.UI.Image m_M_AttackImage = null;
		private UnityEngine.UI.Button m_M_DefenseButton = null;
		private UnityEngine.UI.Image m_M_DefenseImage = null;
		private UnityEngine.UI.Button m_M_ActButton = null;
		private UnityEngine.UI.Image m_M_ActImage = null;
		public Transform uiTransform = null;
	}
