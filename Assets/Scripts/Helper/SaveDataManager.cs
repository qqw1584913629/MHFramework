using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public static class SaveDataManager
{
    public static void SaveDataByPlayerPrefs(string key, object value)
    {
        string serializeObject = JsonConvert.SerializeObject(value);
        PlayerPrefs.SetString(key, serializeObject);
        PlayerPrefs.Save();
    }
    public static T LoadDataByPlayerPrefs<T>()
    {
        var json = PlayerPrefs.GetString(typeof(T).FullName, null);
        return JsonConvert.DeserializeObject<T>(json);
    }
}

public static class CreatePlayerGameDataHandler<T> where T: new()
{
    public static T Create()
    {
        // var data = JsonUtility.FromJson<T>(SaveDataManager.LoadDataByPlayerPrefs(typeof(T).Name));
        var data = SaveDataManager.LoadDataByPlayerPrefs<T>();
        if (data == null)
        {
            T newData = new T();
            SaveDataManager.SaveDataByPlayerPrefs(typeof(T).Name, newData);
            return newData;
        }
        return data;
    }
}