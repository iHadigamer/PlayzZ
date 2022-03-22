using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControllerHard : MonoBehaviour
{

    public static GameControllerHard Instance;

    public float scrollSpeed = 0f;
    public bool isGameOver = false;
    public int score = 0;
    public int scorep2 = 0;
    public bool isPaused = false;
    public Text scoreText;
    public Text scoreTextP2;
    public GameObject gameOver;
    public GameObject p1;
    public GameObject P2;
    int a = 0;
    public Text Win;

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
        if (!isPaused)
        {
            timee++;
            if (timee >= 60) { timee = 0; timeee++; }
            if(timeee == 5) { p1.SetActive(false); P2.SetActive(false); }
            if (timeee == 10) { timeee = 0; Time.timeScale += 0.1f; }
        }
    }

    public void Score()
    {
        if (isGameOver) { return; }

        score++;
        scoreText.text = "Score: " + score;

    }
    public void ScoreP2()
    {
        if (isGameOver) { return; }

        scorep2++;
        scoreTextP2.text = "Score: " + scorep2;

    }

    public void Die()
    {
        a++;
        if (a == 2)
        {
            gameOver.SetActive(true);
            isGameOver = true;
            if (scorep2 == score) { Win.text = "Draw"; }
            if (scorep2 > score) { Win.text = "Player 1 Wines"; Win.GetComponent<Text>().color = Color.green; }
            if (scorep2 < score) { Win.text = "Player 2 Wines"; Win.GetComponent<Text>().color = Color.red; }
        }
    }
    
}
