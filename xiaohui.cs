/****************************************************
    文件：xiaohui.cs
    作者：
    邮箱: 
    日期：#CreateTime#
    功能：Nothing
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xiaohui : MonoBehaviour
{
    public object Instance { get; private set; }

    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}