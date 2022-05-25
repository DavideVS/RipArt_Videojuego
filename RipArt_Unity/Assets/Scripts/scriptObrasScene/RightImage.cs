using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RightImage : MonoBehaviour
{
    public static bool gameWin;
    public GameObject gameWinPanel;
    // Start is called before the first frame update
    void Start()
    {
        gameWin = false;  
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (gameOver) {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }*/

        if (Input.GetMouseButtonDown(0)) {
            //gameWinPanel.SetActive(true);  
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
            RaycastHit hit;  
            if (Physics.Raycast(ray, out hit)) {  
  
               //Select stage    
               if (hit.transform.name == "MonaLisaRight") {  
                   Time.timeScale = 0;
                   //gameWinPanel.SetActive(true);
                   ScoreManager.instance.AddPoint();
                   SceneManager.LoadScene("WinScene");
                }  
            } 
        }   
    }
}