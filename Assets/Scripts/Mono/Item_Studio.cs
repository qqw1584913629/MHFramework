using System.Collections;
using System.Collections.Generic;
using cfg;
using DG.Tweening;
using Helper;
using Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Item_Studio : MonoBehaviour
{
    public Button click;
    public TextMeshProUGUI title;
    public StudioConfig _config;

    private void Start()
    {
        click.AddListener(() =>
        {
            // UIManager.Instance.GetUILogic<DlgSingleManagerSystem>(WindowID.WindowID_SingleManager).Reset();
            if (_config.Id == 1)
            {
                UIManager.Instance.GetUILogic<DlgStudioSystem>(WindowID.WindowID_Studio).Play(true);
            }
            else
            {
                UIManager.Instance.GetUILogic<DlgStudioSystem>(WindowID.WindowID_Studio).Play(false);
            }
        });
    }

    public void SetInfo(StudioConfig config)
    {
        _config = config;
        title.SetText(_config.Info);
    }
}
