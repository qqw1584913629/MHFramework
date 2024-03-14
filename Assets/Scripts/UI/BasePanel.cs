using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePanel : MonoBehaviour
{
    protected bool isRemove = false;
    protected string path;
    public UIWindowType windowType = UIWindowType.Normal; 

    public virtual void ShowWindow(string path)
    {
        this.path = path;
        gameObject.SetActive(true);
    }

    public virtual void CloseWindow()
    {
        this.isRemove = true;
        gameObject.SetActive(false);
        // ResourceHelper.UnLoadGameObjectAsync(gameObject);
        Destroy(gameObject);
    }
    public virtual void HideWindow()
    {
        this.isRemove = true;
        gameObject.SetActive(false);
    }
}
