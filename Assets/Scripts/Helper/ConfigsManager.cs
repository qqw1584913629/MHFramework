#region << 文 件 说 明 >>

/*----------------------------------------------------------------
// 文件名称：ConfigsManager
// 创 建 者：郑以航
// 创建时间：2024年03月05日 星期二 00:03
//===============================================================
// 功能描述：
//		
//
//----------------------------------------------------------------*/

#endregion

using cfg;
using Cysharp.Threading.Tasks;
using Model;
using SimpleJSON;
using UnityEditorInternal;
using UnityEngine;

public static class ConfigsManager
{
    public static Tables tables;
    public async static UniTask Init()
    {
        tables = await cfg.Tables.CreateAsync(Loader);
        LoadSingleQuestion();
        LoadTrueOrFalseQuestion();
    }

    private static async UniTask LoadTrueOrFalseQuestion()
    {
        
    }

    public static async UniTask LoadSingleQuestion()
    {
        var singleInfoComponent = JsonUtility.FromJson<SingleInfoComponent>(PlayerPrefs.GetString(nameof(SingleInfoComponent), Default()));
        singleInfoComponent.lists.Clear();
        foreach (Single single in tables.TbSingle.DataList)
        {
            SingleInfo singleInfo = new SingleInfo();
            singleInfo.id = single.Id;
            singleInfo.question = single.Question;
            singleInfo.ans = single.Ans;
            singleInfo.ans1 = single.Ans1;
            singleInfo.ans2 = single.Ans2;
            singleInfo.ans3 = single.Ans3;
            singleInfo.ans4 = single.Ans4;
            singleInfoComponent.lists.Add(singleInfo);
        }
        SaveDataManager.SaveDataByPlayerPrefs(nameof(SingleInfoComponent), singleInfoComponent);
    }

    private static string Default()
    {
        return JsonUtility.ToJson(new SingleInfoComponent());
    }

    private static async UniTask<JSONNode> Loader(string fileName)
    {
        var content = await ResourceHelper.LoadRawFileASync(fileName);
        return JSON.Parse(content);
    }
}