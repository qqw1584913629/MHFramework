
using UnityEngine;
using UnityEngine.UI;
	public  class Item_TestComponent : MonoBehaviour
	{
		public TMPro.TextMeshProUGUI M_TestTextMeshProUGUI
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_TestTextMeshProUGUI == null )
     			{
		    		this.m_M_TestTextMeshProUGUI = MUIHelepr.FindDeepChild<TMPro.TextMeshProUGUI>(this.uiTransform.gameObject,"M_Test");
     			}
     			return this.m_M_TestTextMeshProUGUI;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_M_TestTextMeshProUGUI = null;
			this.uiTransform = null;
		}

		private TMPro.TextMeshProUGUI m_M_TestTextMeshProUGUI = null;
		public Transform uiTransform = null;
	}
