using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Player()
    {
        SceneManager.LoadScene("TrickyDodge/Scenes/1Player");
    }
    public void Players()
    {
        SceneManager.LoadScene("TrickyDodge/Scenes/2Players");
    }
    public void exitUnity()
    {
        AndroidJavaClass myClass = new AndroidJavaClass("com.unity3d.player.UnityPlayerActivity");
        myClass.Call("quitUnityActivity");
    }
}
