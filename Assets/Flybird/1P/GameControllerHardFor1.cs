using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControllerHardFor1 : MonoBehaviour
{

    public static GameControllerHardFor1 Instance;

    public float scrollSpeed = 0f;
    public bool isGameOver = false;
    public bool isPaused = false;
    public int score = 0;
    public Text scoreText;
    public GameObject gameOver;

    private int timee = 0;
    private int timeee = 0;

    // Use this for initialization
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
        if (!isPaused || Time.timeScale != 0f)
        {
            timee++;
            if (timee >= 60) { timee = 0; timeee++; }
            if (timeee == 10) { timeee = 0; Time.timeScale += 0.1f; }
        }
    }

    public void Score()
    {
        if (isGameOver) { return; }

        score++;
        scoreText.text = "Score: " + score;

    }

    public void Die()
    {
        gameOver.SetActive(true);
        isGameOver = true;
    }
}
