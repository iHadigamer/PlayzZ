using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void player()
    {
        SceneManager.LoadScene("Flybird/Scenes/1P");
    }

    public void plalyers()
    {
        SceneManager.LoadScene("Flybird/Scenes/2P");
    }
    public void exitUnity()
    {
        AndroidJavaClass myClass = new AndroidJavaClass("com.unity3d.player.UnityPlayerActivity");
        myClass.Call("quitUnityActivity");
    }
}
