using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Text.RegularExpressions;

namespace SetAssetBundleTag
{
    public class CreatePlayerModelDataCode
    {
        [MenuItem("CreatePlayerModelDataCodeTools/Create Model Code")]
        public static void SetABLabel() {
 
            // 定义需要打包资源的文件夹根目录
            string strNeedSetLabelRoot = Application.dataPath + "/Scripts/Model/";

            FileInfo[] directoryDIRArray = null;
            DirectoryInfo dirTempInfo = new DirectoryInfo(strNeedSetLabelRoot);
            directoryDIRArray = dirTempInfo.GetFiles();
            foreach (FileInfo currentDir in directoryDIRArray)
            {
                if (currentDir.Extension != ".cs")
                {
                    Debug.LogWarning($"过滤文件：{currentDir.Name}");
                    continue;
                }
                JudgeDirOrFileByRecursive(currentDir);
                Debug.Log($"文件：{currentDir.Name},添加Code成功");
            }
            AssetDatabase.Refresh();
        }
        private static void JudgeDirOrFileByRecursive(FileInfo fileSystemInfo) {
            // 参数检查
            if (fileSystemInfo.Exists == false)
            {
                Debug.LogError("文件或者目录名称："+fileSystemInfo+" 不存在，请检查");
                return;
            }
            SetFileABLabel(fileSystemInfo);
        }
 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileInfoObj">文件（文件信息）</param>
        /// <param name="scenesName">场景名称</param>
        static void SetFileABLabel(FileInfo fileInfoObj) {
            if (fileInfoObj.Extension != ".cs")
            {
                Debug.LogWarning(fileInfoObj.Extension);
                Debug.LogWarning($"过滤文件：{fileInfoObj.Name}");
                return;
            }
            string tmpWinPath = fileInfoObj.FullName;
            string tmpUnityPath = tmpWinPath.Replace("\\","/");
            string strABName = string.Empty;
            var strs = tmpUnityPath.Split("/");
            strABName = strs[strs.Length-1];
            string tmp1 = strABName.Split(".")[0];//去掉后缀 .prefab  .wav  .unity
            string tmp2 = strABName.Split(".")[1];
            WriteAudiosCode(tmp1, tmp2);
        }

        public static void WriteAudiosCode(string name, string type)
        {
            string strDlgName = name;
            string strFilePath = Application.dataPath + "/Scripts/Model/Helper/ModelID.cs" ;

            if(!File.Exists(strFilePath))
            {
                Debug.LogError(" 当前不存在ModelID.cs!!!");
                return;
            }

            string originWindowIdContent = File.ReadAllText(strFilePath);

            if (originWindowIdContent.Contains(strDlgName))
            {
                return;
            }

            int windowIdEndIndex   = GetAudioEndIndex(originWindowIdContent);
            originWindowIdContent  = originWindowIdContent.Insert(windowIdEndIndex, 
                "\tpublic const string ModelID_"+strDlgName + $" = \"{strDlgName}\";\n");
            File.WriteAllText(strFilePath, originWindowIdContent);
        
            Debug.Log($"生成ModelID：{strDlgName}完毕");
        }
        public static int GetAudioEndIndex(string content)
        {
            Regex regex = new Regex("ModelID");
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
}