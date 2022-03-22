using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamecontroler : MonoBehaviour
{
    public static Gamecontroler Instance;

    public float scrollSpeed = -10f;
    public bool isGameOver = false;
    public Text scoreText;
    public Text mistaks;
    public int scoree=0;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject Switch;
    public GameObject Switcher;
    public GameObject Gameover;
    public bool isJumping = false;
    public bool isCroushing = false;

    private int timee=0;
    private int timeee = 0;
    private int swesh = 0;
    private int miss = 0;
    public bool isSwitch = false;
    private int a = 0;
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        Application.targetFrameRate = 45;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + scoree;
        mistaks.text = miss + " Mistakes";
        timee++;
        if (timee >= 35) { timee = 0; timeee++; }
        if (timeee == 10) { timeee = 0; Time.timeScale += 0.1f; swesh++; }
        if (swesh == 2 && a == 0) { Switch.SetActive(true); Invoke("Switchh", 5f); a++; }
        if (swesh == 3) 
        {
            Switcher.SetActive(true);
            swesh = 0;
            Invoke("Awitch", 1f);
        }
    }

    public void Die()
    {
        isGameOver = true;
        Gameover.SetActive(true);
    }
    public void Switchh()
    {
        Switch.SetActive(false);
    }
    public void mis()
    {
        miss++;
    }
    public void Sc()
    {
        scoree++;
    }
    public void Awitch() 
    {
        Switcher.SetActive(false);
        if (b1.active && b2.active)
        {
            b1.SetActive(false);
            b2.SetActive(false);
            b3.SetActive(true);
            b4.SetActive(true);
            isSwitch = true;
        }
        else if (b3.active && b4.active)
        {
            b3.SetActive(false);
            b4.SetActive(false);
            b1.SetActive(true);
            b2.SetActive(true);
            isSwitch = false;
        }
    }
}
