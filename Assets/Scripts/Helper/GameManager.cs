using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using MH;
using Newtonsoft.Json;
using SimpleJSON;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using YooAsset;
using Object = System.Object;
using Random = UnityEngine.Random;

public class GameManager : Singleton<GameManager>
{
    private Dictionary<string, Object> ClientDataCache = new Dictionary<string, object>();
    [Header("YooAsset相关")][SerializeField] private EPlayMode PlayMode = EPlayMode.EditorSimulateMode;

    /// <summary>
    /// 游戏入口Awake脚本
    /// </summary>
    protected override async void Awake()
    {
        base.Awake();
        //初始化yoo
        await InitializeYooAsset();
        //启动游戏显示默认Main UI
        UIManager.Instance.ShowWindow(WindowID.WindowID_Login);
    }
    private async UniTask InitializeYooAsset()
    {
        // 初始化资源系统
        YooAssets.Initialize();

        // 创建默认的资源包
        var package = YooAssets.CreatePackage("DefaultPackage");

        // 设置该资源包为默认的资源包，可以使用YooAssets相关加载接口加载该资源包内容。
        YooAssets.SetDefaultPackage(package);

        if (PlayMode == EPlayMode.EditorSimulateMode)
        {
            var initParameters = new EditorSimulateModeParameters();
            initParameters.SimulateManifestFilePath  = EditorSimulateModeHelper.SimulateBuild("DefaultPackage");
            await package.InitializeAsync(initParameters);
        }
        else if (PlayMode == EPlayMode.OfflinePlayMode)
        {
            var initParameters = new OfflinePlayModeParameters();
            await package.InitializeAsync(initParameters);
        }
        else if (PlayMode == EPlayMode.HostPlayMode)
        {
            // 注意：GameQueryServices.cs 太空战机的脚本类，详细见StreamingAssetsHelper.cs
            string defaultHostServer = "http://127.0.0.1/CDN/Android/v1.0";
            string fallbackHostServer = "http://127.0.0.1/CDN/Android/v1.0";
            var initParameters = new HostPlayModeParameters();
            // todo 如果要使用联机模式则需要配置下面三个东西
            // initParameters.BuildinQueryServices = new GameQueryServices(); 
            // initParameters.DecryptionServices = new FileOffsetDecryption();
            // initParameters.RemoteServices = new RemoteServices(defaultHostServer, fallbackHostServer);
            var initOperation = package.InitializeAsync(initParameters);
            await initOperation;
    
            if(initOperation.Status == EOperationStatus.Succeed)
            {
                Debug.Log("资源包初始化成功！");
            }
            else 
            {
                Debug.LogError($"资源包初始化失败：{initOperation.Error}");
            }
        }
        
        
        var defaultPackage = YooAssets.GetPackage("DefaultPackage");
        var operation = defaultPackage.UpdatePackageVersionAsync();
        await operation;

        if (operation.Status == EOperationStatus.Succeed)
        {
            //更新成功
            string packageVersion = operation.PackageVersion;
            Debug.Log($"Updated package Version : {packageVersion}");
        }
        else
        {
            //更新失败
            Debug.LogError($"更新失败{operation.Error}");
        }
        
        // 更新成功后自动保存版本号，作为下次初始化的版本。
        // 也可以通过operation.SavePackageVersion()方法保存。
        bool savePackageVersion = true;
        var operation1 = defaultPackage.UpdatePackageManifestAsync(operation.PackageVersion, savePackageVersion);
        await operation1;

        if (operation1.Status == EOperationStatus.Succeed)
        {
            //更新成功
        }
        else
        {
            Debug.LogError($"更新失败{operation1.Error}");
        }
        await Download();
        CreatePlayerData();
    }
    async UniTask Download()
    {
        int downloadingMaxNum = 10;
        int failedTryAgain = 3;
        var package = YooAssets.GetPackage("DefaultPackage");
        var downloader = package.CreateResourceDownloader(downloadingMaxNum, failedTryAgain);
    
        //没有需要下载的资源
        if (downloader.TotalDownloadCount == 0)
        {        
            return;
        }

        //需要下载的文件总数和总大小
        int totalDownloadCount = downloader.TotalDownloadCount;
        long totalDownloadBytes = downloader.TotalDownloadBytes;    

        //注册回调方法
        downloader.OnDownloadErrorCallback = OnDownloadErrorFunction;
        downloader.OnDownloadProgressCallback = OnDownloadProgressUpdateFunction;
        downloader.OnDownloadOverCallback = OnDownloadOverFunction;
        downloader.OnStartDownloadFileCallback = OnStartDownloadFileFunction;

        //开启下载
        downloader.BeginDownload();
        await downloader;

        //检测下载结果
        if (downloader.Status == EOperationStatus.Succeed)
        {
            //下载成功
        }
        else
        {
            //下载失败
        }
    }

    private void OnStartDownloadFileFunction(string filename, long sizebytes)
    {
    }

    private void OnDownloadOverFunction(bool issucceed)
    {
    }

    private void OnDownloadProgressUpdateFunction(int totaldownloadcount, int currentdownloadcount, long totaldownloadbytes, long currentdownloadbytes)
    {
    }

    private void OnDownloadErrorFunction(string filename, string error)
    {
    }



    /// <summary>
    /// 创建or读取玩家的Json本地数据
    /// </summary>
    private void CreatePlayerData()
    {
        Type type = typeof(ModelID);
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | 
                                            BindingFlags.Static | 
                                            BindingFlags.FlattenHierarchy);
        foreach (FieldInfo field in fields)
        {
            if (field.IsLiteral && !field.IsInitOnly)
            {
                Debug.Log($"正在初始化玩家数据：{field.Name}");
                //获取玩家数据类型
                var new_Type = Type.GetType((string)field.GetValue(null));
                //获取泛型类型
                var genericType = typeof(CreatePlayerGameDataHandler<>).MakeGenericType(new_Type);
                //获取泛型类型的创建方法
                var createMethod = genericType.GetMethod("Create");
                //调用泛型类型的创建方法，创建玩家数据
                var playerData = createMethod.Invoke(null, null);
                //缓存至字典中
                ClientDataCache.Add(playerData.GetType().Name,  playerData);
                Debug.Log($"{playerData.GetType().Name}：{JsonConvert.SerializeObject(playerData)}");
            }
        }
    }
    /// <summary>
    /// 保存玩家数据
    /// </summary>
    /// <param name="modelId"></param>
    public void SavePlayerGameDataHandler(string modelId)
    {
        //根据传入进来的参数保存数据
        if (ClientDataCache.TryGetValue(modelId, out Object obj))
        {
            SaveDataManager.SaveDataByPlayerPrefs(obj.ToString(), obj);
            return;
        }
        return;
    }
    public void SaveAllPlayerGameDataHandler()
    {
        foreach (var data in ClientDataCache.Values)
            SaveDataManager.SaveDataByPlayerPrefs(data.ToString(), data);
    }
    /// <summary>
    /// 获取玩家数据
    /// </summary>
    /// <param name="modelId"></param>
    /// <returns></returns>
    public T GetPlayerGameDataHandler<T>() where T : class
    {
        if (ClientDataCache.TryGetValue(typeof(T).Name, out Object obj))
            return obj as T;
        return null;
    }

    private void OnApplicationQuit()
    {
        SaveAllPlayerGameDataHandler();
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        SaveAllPlayerGameDataHandler();
    }
}
