
using UnityEngine;
using UnityEngine.UI;
namespace MH
{
	public  class Scroll_Item_ServerInfoViewSystem : MonoBehaviour 
	{
		public Scroll_Item_ServerInfo View;
		private void Awake()
		{
			if (gameObject.GetComponent<Scroll_Item_ServerInfo>() == null)
				View = gameObject.AddComponent<Scroll_Item_ServerInfo>();
			View.uiTransform = transform;
		}
		private void OnDestroy()
		{
			View.DestroyWidget();
		}

	}
}
