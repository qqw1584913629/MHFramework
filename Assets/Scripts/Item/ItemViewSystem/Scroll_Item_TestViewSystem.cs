
using UnityEngine;
using UnityEngine.UI;
namespace MH
{
	public static class Scroll_Item_TestViewSystem 
	{
		public static void SetInfo(this Scroll_Item_Test self, int index)
		{
			self.M_TestTextMeshProUGUI.SetText($"{index}服");
		}
	}
}
