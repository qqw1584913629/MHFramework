
using UnityEngine;
using UnityEngine.UI;
	public  class DlgLoginComponent : MonoBehaviour
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
		    		this.m_M_AccountImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/M_Account");
     			}
     			return this.m_M_AccountImage;
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
		    		this.m_M_PasswordImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Center/M_Password");
     			}
     			return this.m_M_PasswordImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_MG_MaskRectTransform = null;
			this.m_M_AccountImage = null;
			this.m_M_PasswordImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_MG_MaskRectTransform = null;
		private UnityEngine.UI.Image m_M_AccountImage = null;
		private UnityEngine.UI.Image m_M_PasswordImage = null;
		public Transform uiTransform = null;
	}
