using System;
using System.Collections;
using System.Collections.Generic;
using cfg;
using Helper;
using Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Item_Single : MonoBehaviour
{
    public Button click;
    public TextMeshProUGUI title;
    public SingleInfo _config;

    private void Start()
    {
        click.AddListener(() =>
        {
            SingleHelper.Remove(_config);
            UIManager.Instance.GetUILogic<DlgSingleManagerSystem>(WindowID.WindowID_SingleManager).Reset();
        });
    }

    public void SetInfo(SingleInfo config)
    {
        _config = config;
        title.SetText(_config.question);
    }
}
