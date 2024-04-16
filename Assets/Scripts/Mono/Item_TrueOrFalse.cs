using Helper;
using Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mono
{
    public class Item_TrueOrFalse: MonoBehaviour
    {
        public Button click;
        public TextMeshProUGUI title;
        public TrueOrFalseInfo _config;

        private void Start()
        {
            click.AddListener(() =>
            {
                TrueOrFalseHelper.Remove(_config);
                UIManager.Instance.GetUILogic<DlgSingleManagerSystem>(WindowID.WindowID_SingleManager).Reset();
            });
        }

        public void SetInfo(TrueOrFalseInfo config)
        {
            _config = config;
            title.SetText(_config.question);
        }
    }
}