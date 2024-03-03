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
    public static string LoadDataByPlayerPrefs(string key)
    {
        var json = PlayerPrefs.GetString(key, null);
        return json;
    }
}

public static class CreatePlayerGameDataHandler<T> where T: new()
{
    public static T Create()
    {
        var data = JsonUtility.FromJson<T>(SaveDataManager.LoadDataByPlayerPrefs(typeof(T).Name));
        if (data == null)
        {
            T newData = new T();
            SaveDataManager.SaveDataByPlayerPrefs(typeof(T).Name, newData);
            return newData;
        }
        return data;
    }
}