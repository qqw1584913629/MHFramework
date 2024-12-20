
using System.Collections.Generic;
using MH;
using UnityEngine;
using UnityEngine.UI;
	public  class DlgTestComponent : BasePanel, IUILogic
	{
		public Dictionary<int, Scroll_Item_Test> ScrollItemServersMap;

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

		public UnityEngine.UI.Button M_LoginButtonButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_LoginButtonButton == null )
     			{
		    		this.m_M_LoginButtonButton = MUIHelepr.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"M_LoginButton");
     			}
     			return this.m_M_LoginButtonButton;
     		}
     	}

		public UnityEngine.UI.Image M_LoginButtonImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_LoginButtonImage == null )
     			{
		    		this.m_M_LoginButtonImage = MUIHelepr.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"M_LoginButton");
     			}
     			return this.m_M_LoginButtonImage;
     		}
     	}

		public ET.Client.LoopScrollView M_ServerLoopLoopScrollView
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_ServerLoopLoopScrollView == null )
     			{
		    		this.m_M_ServerLoopLoopScrollView = MUIHelepr.FindDeepChild<ET.Client.LoopScrollView>(this.uiTransform.gameObject,"M_ServerLoop");
     			}
     			return this.m_M_ServerLoopLoopScrollView;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_MG_MaskRectTransform = null;
			this.m_M_AccountInputField = null;
			this.m_M_AccountImage = null;
			this.m_M_PasswordInputField = null;
			this.m_M_PasswordImage = null;
			this.m_M_LoginButtonButton = null;
			this.m_M_LoginButtonImage = null;
			this.m_M_ServerLoopLoopScrollView = null;
			this.uiTransform = null;
		}

		private UnityEngine.RectTransform m_MG_MaskRectTransform = null;
		private UnityEngine.UI.InputField m_M_AccountInputField = null;
		private UnityEngine.UI.Image m_M_AccountImage = null;
		private UnityEngine.UI.InputField m_M_PasswordInputField = null;
		private UnityEngine.UI.Image m_M_PasswordImage = null;
		private UnityEngine.UI.Button m_M_LoginButtonButton = null;
		private UnityEngine.UI.Image m_M_LoginButtonImage = null;
		private ET.Client.LoopScrollView m_M_ServerLoopLoopScrollView = null;
		public Transform uiTransform = null;
	}
