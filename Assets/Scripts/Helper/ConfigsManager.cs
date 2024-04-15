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

using System.Linq;
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
        LoadDoubleQuestion();
    }

    private static void LoadDoubleQuestion()
    {
        var doubleInfoComponent = JsonUtility.FromJson<DoubleInfoComponent>(PlayerPrefs.GetString(nameof(DoubleInfoComponent), Default()));
        if (doubleInfoComponent.lists.Count > 0)
            return;
        foreach (DoubleQuestion doubleQuestion in tables.TbDouble.DataList)
        {
            DoubleInfo doubleInfo = new DoubleInfo();
            doubleInfo.id = doubleQuestion.Id;
            doubleInfo.question = doubleQuestion.Question;
            doubleInfo.ans = doubleQuestion.Ans.Split("|").ToList();
            doubleInfo.ans1 = doubleQuestion.Ans1;
            doubleInfo.ans2 = doubleQuestion.Ans2;
            doubleInfo.ans3 = doubleQuestion.Ans3;
            doubleInfo.ans4 = doubleQuestion.Ans4;
            doubleInfoComponent.lists.Add(doubleInfo);
        }
        SaveDataManager.SaveDataByPlayerPrefs(nameof(DoubleInfoComponent), doubleInfoComponent);
    }

    private static void LoadTrueOrFalseQuestion()
    {
        var trueOrFalseInfoComponent = JsonUtility.FromJson<TrueOrFalseInfoComponent>(PlayerPrefs.GetString(nameof(TrueOrFalseInfoComponent), Default2()));
        if (trueOrFalseInfoComponent.lists.Count > 0)
            return;
        foreach (TrueOrFalse trueOrFalse in tables.TbTrueOrFalse.DataList)
        {
            TrueOrFalseInfo trueOrFalseInfo = new TrueOrFalseInfo();
            trueOrFalseInfo.id = trueOrFalse.Id;
            trueOrFalseInfo.question = trueOrFalse.Question;
            trueOrFalseInfo.ans = trueOrFalse.Ans;
            trueOrFalseInfo.ans1 = trueOrFalse.Ans1;
            trueOrFalseInfo.ans2 = trueOrFalse.Ans2;
            trueOrFalseInfoComponent.lists.Add(trueOrFalseInfo);
        }
        SaveDataManager.SaveDataByPlayerPrefs(nameof(TrueOrFalseInfoComponent), trueOrFalseInfoComponent);
    }

    public static void LoadSingleQuestion()
    {
        var singleInfoComponent = JsonUtility.FromJson<SingleInfoComponent>(PlayerPrefs.GetString(nameof(SingleInfoComponent), Default()));
        if (singleInfoComponent.lists.Count > 0)
            return;
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
    private static string Default2()
    {
        return JsonUtility.ToJson(new TrueOrFalseInfoComponent());
    }
    private static async UniTask<JSONNode> Loader(string fileName)
    {
        var content = await ResourceHelper.LoadRawFileASync(fileName);
        return JSON.Parse(content);
    }
}