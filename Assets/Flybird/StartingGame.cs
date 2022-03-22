using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartingGame : MonoBehaviour
{
    public Text Go;
    public GameObject goScreen;
    public int countdownTime;

    public void Start()
    {
        
        StartCoroutine(CountDown());
        
    }

    public IEnumerator CountDown()
    {
        Time.timeScale = 0.001f;
        while (countdownTime > 0)
        {
            Go.text = countdownTime.ToString();
            yield return new WaitForSeconds(0.001f);
            countdownTime--;
        }
        Go.text = "Go!";

        yield return new WaitForSeconds(0.001f);
        Go.gameObject.SetActive(false);
        goScreen.SetActive(false);
        Time.timeScale = 1f;
    }

}
