
using UnityEngine;
using UnityEngine.UI;
namespace MH
{
	public class DlgRedComponent : BasePanel, IUILogic
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
		    		this.m_M_CloseButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"M_Close");
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
		    		this.m_M_CloseImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"M_Close");
     			}
     			return this.m_M_CloseImage;
     		}
     	}

		public UnityEngine.UI.Button M_RootButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_RootButton == null )
     			{
		    		this.m_M_RootButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/M_Root");
     			}
     			return this.m_M_RootButton;
     		}
     	}

		public UnityEngine.UI.Image M_RootImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_RootImage == null )
     			{
		    		this.m_M_RootImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/M_Root");
     			}
     			return this.m_M_RootImage;
     		}
     	}

		public UnityEngine.UI.Button M_Child1Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Child1Button == null )
     			{
		    		this.m_M_Child1Button = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/M_Child1");
     			}
     			return this.m_M_Child1Button;
     		}
     	}

		public UnityEngine.UI.Image M_Child1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Child1Image == null )
     			{
		    		this.m_M_Child1Image = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/M_Child1");
     			}
     			return this.m_M_Child1Image;
     		}
     	}

		public UnityEngine.UI.Button M_Child2Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Child2Button == null )
     			{
		    		this.m_M_Child2Button = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/M_Child2");
     			}
     			return this.m_M_Child2Button;
     		}
     	}

		public UnityEngine.UI.Image M_Child2Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Child2Image == null )
     			{
		    		this.m_M_Child2Image = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/M_Child2");
     			}
     			return this.m_M_Child2Image;
     		}
     	}

		public UnityEngine.UI.Button M_Child3Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Child3Button == null )
     			{
		    		this.m_M_Child3Button = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center/M_Child3");
     			}
     			return this.m_M_Child3Button;
     		}
     	}

		public UnityEngine.UI.Image M_Child3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_Child3Image == null )
     			{
		    		this.m_M_Child3Image = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/M_Child3");
     			}
     			return this.m_M_Child3Image;
     		}
     	}

		public UnityEngine.UI.Button M_AddChild1Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AddChild1Button == null )
     			{
		    		this.m_M_AddChild1Button = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center (1)/M_AddChild1");
     			}
     			return this.m_M_AddChild1Button;
     		}
     	}

		public UnityEngine.UI.Image M_AddChild1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AddChild1Image == null )
     			{
		    		this.m_M_AddChild1Image = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center (1)/M_AddChild1");
     			}
     			return this.m_M_AddChild1Image;
     		}
     	}

		public UnityEngine.UI.Button M_SubChild1Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_SubChild1Button == null )
     			{
		    		this.m_M_SubChild1Button = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center (1)/M_SubChild1");
     			}
     			return this.m_M_SubChild1Button;
     		}
     	}

		public UnityEngine.UI.Image M_SubChild1Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_SubChild1Image == null )
     			{
		    		this.m_M_SubChild1Image = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center (1)/M_SubChild1");
     			}
     			return this.m_M_SubChild1Image;
     		}
     	}

		public UnityEngine.UI.Button M_AddChild3Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AddChild3Button == null )
     			{
		    		this.m_M_AddChild3Button = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center (1)/M_AddChild3");
     			}
     			return this.m_M_AddChild3Button;
     		}
     	}

		public UnityEngine.UI.Image M_AddChild3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_AddChild3Image == null )
     			{
		    		this.m_M_AddChild3Image = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center (1)/M_AddChild3");
     			}
     			return this.m_M_AddChild3Image;
     		}
     	}

		public UnityEngine.UI.Button M_SubChild3Button
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_SubChild3Button == null )
     			{
		    		this.m_M_SubChild3Button = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Center (1)/M_SubChild3");
     			}
     			return this.m_M_SubChild3Button;
     		}
     	}

		public UnityEngine.UI.Image M_SubChild3Image
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_SubChild3Image == null )
     			{
		    		this.m_M_SubChild3Image = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center (1)/M_SubChild3");
     			}
     			return this.m_M_SubChild3Image;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_MG_MaskRectTransform = null;
			this.m_M_CloseButton = null;
			this.m_M_CloseImage = null;
			this.m_M_RootButton = null;
			this.m_M_RootImage = null;
			this.m_M_Child1Button = null;
			this.m_M_Child1Image = null;
			this.m_M_Child2Button = null;
			this.m_M_Child2Image = null;
			this.m_M_Child3Button = null;
			this.m_M_Child3Image = null;
			this.m_M_AddChild1Button = null;
			this.m_M_AddChild1Image = null;
			this.m_M_SubChild1Button = null;
			this.m_M_SubChild1Image = null;
			this.m_M_AddChild3Button = null;
			this.m_M_AddChild3Image = null;
			this.m_M_SubChild3Button = null;
			this.m_M_SubChild3Image = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_MG_MaskRectTransform = null;
		private UnityEngine.UI.Button m_M_CloseButton = null;
		private UnityEngine.UI.Image m_M_CloseImage = null;
		private UnityEngine.UI.Button m_M_RootButton = null;
		private UnityEngine.UI.Image m_M_RootImage = null;
		private UnityEngine.UI.Button m_M_Child1Button = null;
		private UnityEngine.UI.Image m_M_Child1Image = null;
		private UnityEngine.UI.Button m_M_Child2Button = null;
		private UnityEngine.UI.Image m_M_Child2Image = null;
		private UnityEngine.UI.Button m_M_Child3Button = null;
		private UnityEngine.UI.Image m_M_Child3Image = null;
		private UnityEngine.UI.Button m_M_AddChild1Button = null;
		private UnityEngine.UI.Image m_M_AddChild1Image = null;
		private UnityEngine.UI.Button m_M_SubChild1Button = null;
		private UnityEngine.UI.Image m_M_SubChild1Image = null;
		private UnityEngine.UI.Button m_M_AddChild3Button = null;
		private UnityEngine.UI.Image m_M_AddChild3Image = null;
		private UnityEngine.UI.Button m_M_SubChild3Button = null;
		private UnityEngine.UI.Image m_M_SubChild3Image = null;
		public Transform uiTransform = null;
	}
}
