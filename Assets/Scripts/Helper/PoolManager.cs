using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class PoolManager : Singleton<PoolManager>
{
    public List<GoPManager.PoolType> pools = new List<GoPManager.PoolType>();
    public GoPManager poolManager;
    protected override async void Awake()
    {
        base.Awake();
        poolManager = new GoPManager(gameObject);
        poolManager.Register(pools);
        foreach (var item in pools)
            poolManager.CreatePool(item.prefab);
        return;
    }
}