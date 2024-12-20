using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class UIEditorController
{
    [MenuItem("GameObject/CreateMUICodes", false, -2)]
    static public void CreateNewCode()
    {
        GameObject go = Selection.activeObject as GameObject;
        CreateWindowIdCode(go);
    } 
    /// <summary>
    /// 自动生成WindowId代码
    /// </summary>
    /// <param name="gameObject"></param>
    static void CreateWindowIdCode(GameObject gameObject)
    {
        
        UIFindHelper.SpawnDlgCode(gameObject);

        
        string strDlgName = gameObject.name;
        string strFilePath = Application.dataPath + "/Scripts/UI/UIHelper/WindowID.cs" ;

        if (!strDlgName.StartsWith("Dlg"))
        {
            Debug.LogError("当前GameObject不是Dlg开头");
            return;
        }
        
        if(!File.Exists(strFilePath))
        {
            Debug.LogError(" 当前不存在WindowId.cs!!!");
            return;
        }
	    
        string originWindowIdContent = File.ReadAllText(strFilePath);
        if (originWindowIdContent.Contains(strDlgName.Substring(3)))
        {
            return;
        }
        int windowIdEndIndex   = GetWindowIdEndIndex(originWindowIdContent);
        originWindowIdContent  = originWindowIdContent.Insert(windowIdEndIndex, 
            "\tWindowID_"+strDlgName.Substring(3) + ",\r\n");
        File.WriteAllText(strFilePath, originWindowIdContent);
        
        Debug.Log($"生成WindowID：{strDlgName}完毕");

    }
    public static int GetWindowIdEndIndex(string content)
    {
        Regex regex = new Regex("WindowID");
        Match match = regex.Match(content);
        Regex regex1 = new Regex("}");
        MatchCollection matchCollection = regex1.Matches(content);
        for (int i = 0; i < matchCollection.Count; i++)
        {
            if (matchCollection[i].Index > match.Index)
            {
                return matchCollection[i].Index;
            }
        }
        return -1;
    }
}
