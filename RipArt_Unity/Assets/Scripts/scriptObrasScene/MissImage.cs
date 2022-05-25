using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class MissImage : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;   
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
            gameOverPanel.SetActive(true);
            //SceneManager.LoadScene("GameOverScene");
            /*
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
            RaycastHit hit;  
            if (Physics.Raycast(ray, out hit)) {  
  
               //Select stage    
               if (hit.transform.name == "MonaLisaFake") {  
                   //SceneManager.LoadScene("Test_Map");
                   Time.timeScale = 0;
                   gameOverPanel.SetActive(true);
                   SceneManager.LoadScene("Menu_inicial");
                   //await Task.Delay(2000);   
                }  
            }*/    
        }   
    }
}
