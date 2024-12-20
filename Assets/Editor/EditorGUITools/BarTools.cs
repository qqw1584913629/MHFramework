using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using ToolbarExtension;
using UnityEditor;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class BarTools
{
    [Toolbar(OnGUISide.Left, 0)]
    static void OpenExcelFolder()
    {
        if (GUILayout.Button("打开配置表文件夹"))
        {
            string folderPath = "Excel";

            // 获取项目根目录
            string projectRoot = Application.dataPath.Substring(0, Application.dataPath.Length - "Assets".Length);

            // 构建完整的文件夹路径
            string fullFolderPath = Path.Combine(projectRoot, folderPath);

            // 获取文件夹中的文件列表
            string[] files = Directory.GetFiles(fullFolderPath);

            // 判断文件夹中是否有文件
            if (files.Length > 0)
            {
                // 取第一个文件
                string firstFilePath = files[0];

                // 连接文件路径和文件夹路径
                string fullFilePath = Path.Combine(fullFolderPath, firstFilePath);

                // 在 Unity 编辑器中打开文件夹
                EditorUtility.RevealInFinder(fullFilePath);
            }
        }
    }
}
