using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public List<GoPManager.PoolType> pools = new List<GoPManager.PoolType>();
    public GoPManager poolManager;
    public static PoolManager instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {   
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        poolManager = new GoPManager(gameObject);
        poolManager.Register(pools);
        foreach (var item in pools)
            poolManager.CreatePool(item.prefab);
    }
    
}