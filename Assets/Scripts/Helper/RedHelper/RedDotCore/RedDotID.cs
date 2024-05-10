using System.Collections.Generic;

namespace RedDotTutorial_1
{
    public enum RedDotType
    {
        None,
        Test,
        Child1,
        Child2,
    }
    /// <summary>
    /// 红点路径定义
    /// </summary>
    public static class E_RedDotDefine
    {
        /// <summary>
        /// 红点树的根节点
        /// </summary>
        public const string rdRoot = "Root";


        // ---------- 业务红点 ----------

        public const string Test = "Root/Test";
        public const string Child1 = "Root/Test/Child1";
        public const string Child2 = "Root/Test/Child2";
    }
    public partial class RedDotSystem
    {
        /// <summary>
        /// 红点路径的表（每次 E_RedDotDefine 添加完后此处也必须添加）
        /// </summary>
        public static List<string> lstRedDotTreeList = new List<string>
        {
            E_RedDotDefine.rdRoot,

            E_RedDotDefine.Test,
            E_RedDotDefine.Child1,
            E_RedDotDefine.Child2,
        };
    }
}