
using UnityEngine;
using UnityEngine.UI;
using EnhancedUI.EnhancedScroller;
namespace MH
{
	[RequireComponent(typeof(Scroll_Item_ServerInfo))]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public  class Scroll_Item_ServerInfoViewSystem : EnhancedScrollerCellView 
	{
		public Scroll_Item_ServerInfo View;
		private void Awake()
		{
			cellIdentifier = typeof(Scroll_Item_ServerInfoViewSystem).ToString();
			View = gameObject.GetComponent<Scroll_Item_ServerInfo>();
			View.uiTransform = transform;
		}
		private void OnDestroy()
		{
			View.DestroyWidget();
		}

	}
}
