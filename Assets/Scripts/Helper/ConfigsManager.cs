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
using SimpleJSON;
using UnityEngine;

public static class ConfigsManager
{
    public static Tables tables;
    public async static UniTask Init()
    {
        tables = await cfg.Tables.CreateAsync(Loader);
    }
    private static async UniTask<JSONNode> Loader(string fileName)
    {
        var content = await ResourceHelper.LoadRawFileASync(fileName);
        return JSON.Parse(content);
    }
}