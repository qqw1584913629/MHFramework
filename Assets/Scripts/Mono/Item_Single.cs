using System;
using System.Collections;
using System.Collections.Generic;
using cfg;
using Model;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Item_Single : MonoBehaviour
{
    public Button click;
    public TextMeshProUGUI title;

    private void Start()
    {
        click.AddListener(() =>
        {
            
        });
    }

    public void SetInfo(SingleInfo config)
    {
        title.SetText(config.question);
    }
}
