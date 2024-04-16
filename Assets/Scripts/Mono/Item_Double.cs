using Helper;
using Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mono
{
    public class Item_Double: MonoBehaviour
    {
        public Button click;
        public TextMeshProUGUI title;
        public DoubleInfo _config;

        private void Start()
        {
            click.AddListener(() =>
            {
                DoubleHelper.Remove(_config);
                UIManager.Instance.GetUILogic<DlgDoubleManagerSystem>(WindowID.WindowID_DoubleManager).Reset();
            });
        }
        public void SetInfo(DoubleInfo config)
        {
            _config = config;
            title.SetText(_config.question);
        }
    }
}