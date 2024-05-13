
using System.Collections.Generic;
namespace RedDotTutorial_1
{
	public enum RedDotType
	{
		None,
		Test,
		Child1,
		Child2,
		Child3,
	}
	public static class E_RedDotDefine
	{
		public const string rdRoot = "Root";
		public const string Test = "Root/Test";
		public const string Child1 = "Root/Test/Child1";
		public const string Child2 = "Root/Test/Child2";
		public const string Child3 = "Root/Test/Child2/Child3";
	}
	public partial class RedDotSystem
	{
		public static List<string> lstRedDotTreeList = new List<string>
		{
			E_RedDotDefine.rdRoot,
			E_RedDotDefine.Test,
			E_RedDotDefine.Child1,
			E_RedDotDefine.Child2,
			E_RedDotDefine.Child3,
		};
	}
}
