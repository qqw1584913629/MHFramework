using System.Collections.Generic;
using System.Linq;
using Model;
using UnityEngine;

namespace Helper
{
    public static class SingleHelper
    {
        public static SingleInfoComponent data;

        public static SingleInfoComponent Data
        {
            get
            {
                if (data == null)
                {
                    data = JsonUtility.FromJson<SingleInfoComponent>(
                        SaveDataManager.LoadDataByPlayerPrefs(nameof(SingleInfoComponent)));
                }
                return data;
            }
        }
        public static void Add(SingleInfo info)
        {
            var singleInfos = Data.lists;
            singleInfos.Add(info);
            Data.lists = singleInfos;
            SaveDataManager.SaveDataByPlayerPrefs(nameof(SingleInfoComponent), Data);
        }
        public static SingleInfo Get(int id)
        {
            var firstOrDefault = Data.lists.FirstOrDefault(d => d.id.Equals(id));
            return firstOrDefault;
        }
        public static void Remove(SingleInfo info)
        {
            var singleInfos = Data.lists;
            if (Get(info.id) != null)
                singleInfos.RemoveAt(info.id - 1);
            Data.lists = singleInfos;
            SaveDataManager.SaveDataByPlayerPrefs(nameof(SingleInfoComponent), Data);
        }
    }
}