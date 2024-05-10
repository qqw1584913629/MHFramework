using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using RedDotTutorial_1;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(RedDotItem))]
public class InitRedDotLayer : Editor
{
    public override void OnInspectorGUI()
    {
        // 如果需要的话，可以先绘制默认的Inspector
        DrawDefaultInspector();
        
        // 强转为 MyScript 类型，以便访问其公共方法和属性
        RedDotItem script = (RedDotItem)target;

        // 创建一个自定义的GUI样式
        GUIStyle customButtonStyle = new GUIStyle(GUI.skin.button);
        
        // 设置按钮的颜色
        customButtonStyle.normal.textColor = Color.black;
        customButtonStyle.normal.background = MakeTex(600, 1, new Color(0,.7f,.5f)); // 假设按钮宽度为600

        GUILayout.Space(10); // 添加一些间隔

        // 创建一个按钮，并设置高度为40
        if (GUILayout.Button("自定义按钮", customButtonStyle, GUILayout.Height(120)))
        {
            // 当按钮被按下时调用 MyScript 上的 MyButtonClick 方法
            CreateRedDotIDCode(script.name, script.isRoot, script.parent.ToString());
        }
    }

    // 辅助函数，用于创建纯色的Texture2D
    private Texture2D MakeTex(int width, int height, Color col)
    {
        Color[] pix = new Color[width * height];
        for (int i = 0; i < pix.Length; i++)
            pix[i] = col;

        Texture2D result = new Texture2D(width, height);
        result.SetPixels(pix);
        result.Apply();

        return result;
    }
    public static void CreateRedDotIDCode(string id, bool isRoot, string parent)
    {
        SpawnCode(id, isRoot, parent);
    }
    static void SpawnCode(string id, bool isRoot, string parent)
    {
        string strClassName = "RedDotID";

        string strFilePath = Application.dataPath + "/Scripts/Helper/RedHelper/RedDotCore/" + strClassName + ".cs";
        var sw = new StreamWriter(strFilePath, false, Encoding.UTF8);
        using (sw)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendLine().AppendLine("using System.Collections.Generic;\n");
            strBuilder.AppendLine("namespace RedDotTutorial_1");
            strBuilder.AppendLine("{");
            strBuilder.AppendLine("\tpublic enum RedDotType");
            strBuilder.AppendLine("\t{");
            strBuilder.AppendLine("\t\tNone,\n");
            foreach (var item in RedDotSystem.lstRedDotTreeList)
            {
                var strings = item.Split("/");
                strBuilder.AppendLine($"\t\t{strings[^1]},\n");
            }
            strBuilder.AppendLine($"\t\t{id},\n");
            strBuilder.AppendLine("\t}");
            strBuilder.AppendLine("\tpublic static class E_RedDotDefine\n");
            strBuilder.AppendLine("\t{");
            strBuilder.AppendLine("\t\tpublic const string rdRoot = \"Root\";");
            foreach (var item in RedDotSystem.lstRedDotTreeList)
            {
                var strings = item.Split("/");
                strBuilder.AppendLine($"\t\tpublic const string {strings[^1]} = {item};\n");
            }
            if (isRoot)
                strBuilder.AppendLine($"\t\tpublic const string {id} = Root/{id};\n");
            else
            {
                string FindByLastSegment(List<string> strs, string targetSegment)
                {
                    return strs.SingleOrDefault(str => str.Split('/').Last() == targetSegment);
                }
                strBuilder.AppendLine($"\t\tpublic const string {id} = {FindByLastSegment(RedDotSystem.lstRedDotTreeList, parent)}/{id};\n");
            }
            strBuilder.AppendLine("\t}");
            strBuilder.AppendLine("\tpublic partial class RedDotSystem\n");
            strBuilder.AppendLine("\t{");
            strBuilder.AppendLine("\t\tpublic static List<string> lstRedDotTreeList = new List<string>");
            strBuilder.AppendLine("\t\t{");
            strBuilder.AppendLine($"\t\t\tE_RedDotDefine.rdRoot,\n");
            foreach (var item in RedDotSystem.lstRedDotTreeList)
            {
                var strings = item.Split("/");
                strBuilder.AppendLine($"\t\t\tE_RedDotDefine.{strings[^1]},\n");
            }
            strBuilder.AppendLine("\t\t};");
            strBuilder.AppendLine("\t}");
            strBuilder.AppendLine("}");
        
            sw.Write(strBuilder);
            sw.Flush();
        }
    }
}
