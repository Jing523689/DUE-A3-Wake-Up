/****************************************************
    文件：Main.cs
    作者：
    邮箱: 
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{

    private void Awake()
    {
       
            // 获取所有的音频源
            AudioSource[] allAudioSources = Resources.FindObjectsOfTypeAll<AudioSource>();

            // 遍历所有音频源，设置静音状态
            foreach (AudioSource audioSource in allAudioSources)
            {
                audioSource.mute = GlobalVolumeController.ins.isMuted;
            }
        
    }
    public void OnExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;

#else

        Application.Quit();

#endif
    }

    public void sceneto(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }

}
