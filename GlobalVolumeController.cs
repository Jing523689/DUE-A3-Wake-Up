/****************************************************
    文件：GlobalVolumeController.cs
    作者：
    邮箱: 
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using UnityEngine;
using UnityEngine.UI;

public class GlobalVolumeController : MonoBehaviour
{
    public static GlobalVolumeController ins;
    public  bool isMuted = true;  // 是否已静音
    public Sprite[] sprites;
    public Image image;
    private void Awake()
    {
        ins = this;
    }
 
    public  void ToggleMute()
    {
        // 获取所有的音频源
        AudioSource[] allAudioSources = Resources.FindObjectsOfTypeAll < AudioSource >();

        // 遍历所有音频源，设置静音状态
        foreach (AudioSource audioSource in allAudioSources)
        {
            audioSource.mute = !isMuted;
        }

        // 切换静音状态
        isMuted = !isMuted;
        image.sprite = !isMuted ? sprites[0]:sprites[1];
        // 输出当前静音状态到控制台
        Debug.Log("全局音量已" + (isMuted ? "静音" : "恢复"));
    }
    public void Quit() {

        Application.Quit();
    }
    public void Setting(GameObject obj) {

        obj.SetActive(!obj.activeSelf);
    }
}