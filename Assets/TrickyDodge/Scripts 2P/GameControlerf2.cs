using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControlerf2 : MonoBehaviour
{
    public static GameControlerf2 Instance;

    public float scrollSpeed = -10f;
    public bool isGameOver = false;
    public Text scoreTextP1;
    public Text scoreTextP2;
    public int scoreP1 = 0;
    public int scoreP2 = 0;
    public GameObject b11;
    public GameObject b21;
    public GameObject b31;
    public GameObject b41;
    public GameObject b12;
    public GameObject b22;
    public GameObject b32;
    public GameObject b42;
    public GameObject Switch;
    public GameObject Switcher;
    public GameObject Gameover;
    public bool isJumping = false;
    public bool isCroushing = false;

    private int timee = 0;
    private int timeee = 0;
    private int swesh = 0;
    private int dead = 0;
    private int a=0;
    public bool isSwitch = false;

    void Awake()
    {
        Time.timeScale = 1f;
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
    void Update()
    {
        if (dead == 2) { Die(); }
        scoreTextP1.text = "Score:" + scoreP1;
        scoreTextP2.text = "Score:" + scoreP2;
        timee++;
        if (timee >= 35) { timee = 0; timeee++; }
        if (timeee == 10) { timeee = 0; Time.timeScale += 0.1f; swesh++; }
        if (swesh == 2 && a ==0 ) { Switch.SetActive(true); Invoke("Switchh", 3f); a++; }
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
    public void ScP1()
    {
        scoreP1++;
    }
    public void ScP2()
    {
        scoreP2++;
    }
    public void PDie()
    {
        dead++;
    }
    public void Awitch()
    {
        if (b11.active && b21.active && b12.active && b22.active)
        {
            b11.SetActive(false);
            b21.SetActive(false);
            b31.SetActive(true);
            b41.SetActive(true);
            b12.SetActive(false);
            b22.SetActive(false);
            b32.SetActive(true);
            b42.SetActive(true);
            isSwitch = true;
        }
        else if (b31.active && b41.active && b32.active && b42.active)
        {
            b31.SetActive(false);
            b41.SetActive(false);
            b11.SetActive(true);
            b21.SetActive(true);
            b32.SetActive(false);
            b42.SetActive(false);
            b12.SetActive(true);
            b22.SetActive(true);
            isSwitch = false;
        }
        Switcher.SetActive(false);
    }   
}
