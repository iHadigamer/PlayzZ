using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public GameObject panel;
    private float time;

    public void pause()
    {
        panel.SetActive(true);
        time = Time.timeScale;
        Time.timeScale = 0f;
        GameControllerHard.Instance.isPaused = true;
    }
    public void Resume()
    {
        panel.SetActive(false);
        Time.timeScale = time;
    }
    public void MainMenue()
    {
        SceneManager.LoadScene("Flybird/Scenes/Mainmenu");
    }
    public void exitUnity()
    {
        AndroidJavaClass myClass = new AndroidJavaClass("com.unity3d.player.PlayerActivity");
        myClass.Call("quitUnityActivity");
    }
    public void Over()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
