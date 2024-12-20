using System.Collections.Generic;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.U2D;
using YooAsset;

public static class ResourceHelper
{
    /// <summary>
    /// 同步加载包的所有资源
    /// </summary>
    /// <param name="packageName"></param>
    /// <param name="path"></param>
    /// <returns></returns>
    public static List<GameObject> LoadGameObjectsSync(string packageName, string path)
    {
        var defaultPackage = YooAssets.GetPackage(packageName);
        List<GameObject> res = new List<GameObject>();
        var asyncOperationHandle = defaultPackage.LoadAllAssetsSync(path);
        foreach (var item in asyncOperationHandle.AllAssetObjects)
            res.Add(item as GameObject);
        return res;
    }
    /// <summary>
    /// 同步加载游戏资源
    /// </summary>
    /// <param name="path">资源名字（可寻址）</param>
    /// <typeparam name="T">资源类型：GameObject、AudioClip、Sprite</typeparam>
    /// <returns></returns>
    public static T LoadGameObjectSync<T>(string path) where T : UnityEngine.Object
    {
        var asyncOperationHandle = YooAssets.LoadAssetSync<T>(path);
        return asyncOperationHandle.AssetObject as T;
    }
    /// <summary>
    /// 同步加载游戏资源
    /// </summary>
    /// <param name="path">资源名字（可寻址）</param>
    /// <typeparam name="T">资源类型：GameObject、AudioClip、Sprite</typeparam>
    /// <returns></returns>
    public static List<T> LoadGameObjectAllSync<T>(string path) where T : UnityEngine.Object
    {
        List<T> res = new List<T>();
        var asyncOperationHandle = YooAssets.LoadAllAssetsSync<T>(path);
        foreach (var assetObject in asyncOperationHandle.AllAssetObjects)
            res.Add(assetObject as T);
        return res;
    }
    /// <summary>
    /// 异步加载资源
    /// </summary>
    /// <param name="path"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static async UniTask<T> LoadGameObjectASync<T>(string path) where T : UnityEngine.Object
    {
        var asyncOperationHandle = YooAssets.LoadAssetAsync<T>(path);
        await asyncOperationHandle.ToUniTask();
        return asyncOperationHandle.AssetObject as T;
    }
    /// <summary>
    /// 同步加载图集内容加载资Sprite
    /// </summary>
    /// <param name="assetName"></param>
    /// <param name="spriteName"></param>
    /// <returns></returns>
    public static Sprite LoadAssetSync(string assetName, string spriteName) 
    {
        var  handle= YooAssets.LoadSubAssetsSync<SpriteAtlas>(assetName);
        return handle.GetSubAssetObject<Sprite>(spriteName);
    }
    /// <summary>
    /// 异步加载场景
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static async UniTask<string> LoadSceneAsync(string path)
    {
        string location = path;
        var sceneMode = UnityEngine.SceneManagement.LoadSceneMode.Single;
        bool suspendLoad = false;
        var handle = YooAssets.LoadSceneAsync(location, sceneMode, suspendLoad);
        await handle.ToUniTask();
        return handle.SceneObject.name;
    }
    /// <summary>
    /// 同步加载原生文件
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public static string LoadRawFileSync(string fileName)
    {
        var rawFileText = YooAssets.LoadRawFileSync(fileName).GetRawFileText();
        return rawFileText;
    }
    /// <summary>
    /// 异步加载原生文件
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public static async UniTask<string> LoadRawFileAsync(string fileName)
    {
        var rawFileText = YooAssets.LoadRawFileAsync(fileName);
        await rawFileText.ToUniTask();
        return rawFileText.GetRawFileText();
    }
}
