using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveDataManager
{
    public static void SaveDataByPlayerPrefs(string key, object value)
    {
        var json = JsonUtility.ToJson(value);
        PlayerPrefs.SetString(key, json);
        PlayerPrefs.Save();
        Debug.Log(json);
    }
    public static T LoadDataByPlayerPrefs<T>()
    {
        var json = PlayerPrefs.GetString(typeof(T).FullName, null);
        var fromJson = JsonUtility.FromJson<T>(json);
        return fromJson;
    }
}

public static class CreatePlayerGameDataHandler<T> where T: new()
{
    public static T Create()
    {
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