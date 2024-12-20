using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class  GoPManager
{
    [System.Serializable]
    public class PoolType
    {
        public GameObject prefab;
        public int initialSize;
        public bool autoIncrease;
    }
    List<PoolType> pools = new List<PoolType>();
    GameObject attachedObject;
    Transform transform;
    Dictionary<string, Queue<GameObject>> pooledObjects = new Dictionary<string, Queue<GameObject>>();
    Dictionary<string, List<GameObject>> spawnedObjects = new Dictionary<string, List<GameObject>>();
    public GoPManager(GameObject attach)
    {
        attachedObject = attach;
        transform = attachedObject.transform;
    }
    public void Register(PoolType pool)
    {
        if (pool != null)
            if (!pools.Exists(p => { return p.prefab == pool.prefab; }))
                pools.Add(pool);
    }
    public void Register(List<PoolType> pools)
    {
        foreach (PoolType pool in pools)
            Register(pool);
    }
    public void CreatePool(GameObject prefab)
    {
        if (prefab != null)
        {
            PoolType startupPool = pools.Find(sp => { return sp.prefab == prefab; });
            if (startupPool != null)
            {
                if (!pooledObjects.ContainsKey(prefab.name))
                {
                    Queue<GameObject> poolObjects = new Queue<GameObject>();
                    for (int i = 0; i < startupPool.initialSize; i++)
                    {
                        GameObject go = GameObject.Instantiate(prefab, transform.position, transform.rotation, transform);
                        go.SetActive(false);
                        poolObjects.Enqueue(go);
                    }
                    pooledObjects.Add(prefab.name, poolObjects);
                }
            }
        }
    }
    public GameObject Spawn(GameObject prefab,Vector3 position,Quaternion rotation,Transform parent = null)
    {
        PoolType poolType = pools.Find(p => { return p.prefab.name.Equals(prefab.name); });
        if (prefab != null && poolType != null && pooledObjects.ContainsKey(prefab.name))
        {
            GameObject obj;
            if (pooledObjects.TryGetValue(prefab.name, out Queue<GameObject> poolObjects))
            {
                if (poolObjects.Count > 0)
                {
                    obj = poolObjects.Dequeue();
                    obj.transform.position = position;
                    obj.transform.rotation = rotation;
                    obj.transform.SetParent(parent);
                    obj.SetActive(true);
                }
                else
                {
                    if (poolType.autoIncrease)
                        obj = GameObject.Instantiate(prefab, position, rotation, parent);
                    else
                        obj = null;
                }
                if(obj != null)
                {
                    if (spawnedObjects.TryGetValue(prefab.name, out List<GameObject> spawnObjects))
                        spawnObjects.Add(obj);
                    else
                    {
                        spawnObjects = new List<GameObject> { obj };
                        spawnedObjects.Add(prefab.name, spawnObjects);
                    }
                }
                return obj;
            }
            else
                return null;          
        }
        else
            return null;
    }
    public void Recycle(GameObject prefab,GameObject obj)
    {
        if (prefab != null && obj != null)
        {
            if (spawnedObjects.TryGetValue(prefab.name, out List<GameObject> spawnObjects))
            {
                if (spawnObjects.Contains(obj))
                {
                    obj.transform.position = transform.position;
                    obj.transform.rotation = transform.rotation;
                    // obj.transform.parent = transform;
                    obj.SetActive(false);
                    spawnObjects.Remove(obj);
                    pooledObjects[prefab.name].Enqueue(obj);
                }
            }
        }
    }
    public void Recycle(GameObject obj)
    {
        if (obj != null)
        {
            var prefab = spawnedObjects.Keys.FirstOrDefault(p => spawnedObjects[p].Contains(obj));
            if (!string.IsNullOrWhiteSpace(prefab))
            {
                if (spawnedObjects.TryGetValue(prefab, out List<GameObject> spawnObjects))
                {
                    if (spawnObjects.Contains(obj))
                    {
                        obj.transform.position = transform.position;
                        obj.transform.rotation = transform.rotation;
                        obj.transform.SetParent(transform);
                        obj.SetActive(false);
                        spawnObjects.Remove(obj);
                        pooledObjects[prefab].Enqueue(obj);
                    }
                }
            }
        }
    }
    public void Recycle(string prefabName, GameObject gameObject)
    {
        prefabName = prefabName.Split('(')[0];
        if (!string.IsNullOrEmpty(prefabName))
        {
            var prefab = spawnedObjects.Keys.FirstOrDefault(s => s.Equals(prefabName));
            if (prefab != null && spawnedObjects.TryGetValue(prefab, out List<GameObject> spawnObjects))
                Recycle(gameObject);
        }
    }
    public void RecycleAll()
    {
        // foreach (var item in spawnedObjects)
        //     Recycle(item.Key);
        // 创建一个临时列表来存储需要回收的对象
        List<GameObject> objectsToRecycle = new List<GameObject>();

        // 收集所有需要回收的对象
        foreach (var item in spawnedObjects)
        {
            objectsToRecycle.AddRange(item.Value);
        }

        // 进行回收操作
        foreach (var obj in objectsToRecycle)
        {
            Recycle(obj);
        }
    }
}
