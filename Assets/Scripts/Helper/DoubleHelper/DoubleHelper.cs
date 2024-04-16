using System.Linq;
using Model;
using UnityEngine;

namespace Helper
{
    public static class DoubleHelper
    {
        public static DoubleInfoComponent data;

        public static DoubleInfoComponent Data
        {
            get
            {
                if (data == null)
                {
                    data = JsonUtility.FromJson<DoubleInfoComponent>(
                        SaveDataManager.LoadDataByPlayerPrefs(nameof(DoubleInfoComponent)));
                }
                return data;
            }
        }
        public static void Add(DoubleInfo info)
        {
            var doubleInfos = Data.lists;
            doubleInfos.Add(info);
            Data.lists = doubleInfos;
            SaveDataManager.SaveDataByPlayerPrefs(nameof(DoubleInfoComponent), Data);
        }
        public static DoubleInfo Get(int id)
        {
            var firstOrDefault = Data.lists.FirstOrDefault(d => d.id.Equals(id));
            return firstOrDefault;
        }
        public static void Remove(DoubleInfo info)
        {
            var singleInfos = Data.lists;
            if (Get(info.id) != null)
                singleInfos.RemoveAt(info.id - 1);
            Data.lists = singleInfos;
            SaveDataManager.SaveDataByPlayerPrefs(nameof(DoubleInfoComponent), Data);
        }
    }
}