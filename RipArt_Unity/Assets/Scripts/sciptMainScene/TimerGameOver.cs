using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerGameOver : MonoBehaviour
{
    int countDownStartValue = 120;
    public Text timerUI;

    public static bool gameOver;
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
        gameOver = false;
    }

    void countDownTimer () {
        if (countDownStartValue >= 0) {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = "" + spanTime.Minutes + " : " + spanTime.Seconds;
            //Debug.Log("Timer : " + countDownStartValue);
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else {
            //timerUI.text = "GameOver!";
            //Debug.Log("GameOver!");
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            //SceneManager.LoadScene("Test_Map"); 
        }
    }
/*
    void Update()
    {
        if (gameOver) {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }   
    }*/
}
