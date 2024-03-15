
using UnityEngine;
using UnityEngine.UI;
namespace MH
{
	public  class Scroll_Item_ServerInfo : MonoBehaviour, IUIScrollItem 
	{
		public Scroll_Item_ServerInfo BindTrans(Transform trans)
		{
			this.uiTransform = trans;
			return this;
		}

		public TMPro.TextMeshProUGUI M_TextTextMeshProUGUI
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Debug.LogError("uiTransform is null.");
     				return null;
     			}
     			if( this.m_M_TextTextMeshProUGUI == null )
     			{
		    		this.m_M_TextTextMeshProUGUI = MUIHelepr.FindDeepChild<TMPro.TextMeshProUGUI>(this.uiTransform.gameObject,"M_Text");
     			}
     			return this.m_M_TextTextMeshProUGUI;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_M_TextTextMeshProUGUI = null;
			this.uiTransform = null;
		}

		private TMPro.TextMeshProUGUI m_M_TextTextMeshProUGUI = null;
		public Transform uiTransform = null;
	}
}
