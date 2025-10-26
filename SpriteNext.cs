/****************************************************
    文件：SpriteNext.cs
    作者：
    邮箱: 
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using UnityEngine;

public class SpriteNext : MonoBehaviour 
{
    public GameObject[] games;
    public void Next()
    {
        Invoke(nameof(wait), 0.5f);
        

    }
    public void wait()
    {
        games[0].SetActive(false);
        games[1].SetActive(true);
    }
}