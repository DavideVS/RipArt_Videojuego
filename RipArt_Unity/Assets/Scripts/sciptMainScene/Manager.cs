using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public static bool gameOver;
    //public GameObject gameOverPanel;

    private void Awake()
    {
        gameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {  }

    // Update is called once per frame
    void Update()
    {
        if (gameOver) {
            Time.timeScale = 0;
            //gameOverPanel.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //SceneManager.LoadScene("GameOverScene");
            //gameObject.SetActive(false);
        }   
    }
/*
    public void ReplayGame () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //SceneManager.LoadScene("GameOverScene");
    }*/
}
