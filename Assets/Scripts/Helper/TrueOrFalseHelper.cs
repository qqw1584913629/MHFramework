using System.Linq;
using Model;
using UnityEngine;

namespace Helper
{
    public static class TrueOrFalseHelper
    {
        public static TrueOrFalseInfoComponent data;

        public static TrueOrFalseInfoComponent Data
        {
            get
            {
                if (data == null)
                {
                    data = JsonUtility.FromJson<TrueOrFalseInfoComponent>(
                        SaveDataManager.LoadDataByPlayerPrefs(nameof(TrueOrFalseInfoComponent)));
                }
                return data;
            }
        }
        public static TrueOrFalseInfo Get(int id)
        {
            var firstOrDefault = Data.lists.FirstOrDefault(d => d.id.Equals(id));
            return firstOrDefault;
        }
        public static void Remove(TrueOrFalseInfo info)
        {
            var trueOrFalse = Data.lists;
            if (Get(info.id) != null)
                trueOrFalse.RemoveAt(info.id - 1);
            Data.lists = trueOrFalse;
            SaveDataManager.SaveDataByPlayerPrefs(nameof(TrueOrFalseInfoComponent), Data);
        }
    }
}