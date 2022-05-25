using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryGame2 : MonoBehaviour
{
    
    public static RetryGame2 instance;
    public Text scoreText;
    int score = 0;

    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update    
    void Start() {
        //scoreText.text = score.ToString() + " Points";
    }  
  
    // Update is called once per frame    
    void Update() {
            if (Input.GetMouseButtonDown(0)) {
               //Original.active = true;
               RaycastHit hit;
               Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit)) {
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null) {
                    //Destroy(Original);
                    //Destroy(bc.gameObject);
                    //SceneManager.LoadScene("Test_Map");
                    score += 1;
                    scoreText.text = score.ToString() + " Points";
                    SceneManager.LoadScene("Test_Map");
                }
                else {
                  SceneManager.LoadScene("GameOverScene");
                }
            }
            /*
            Original = GameObject.FindWithTag ("Original");
            Destroy(Original);
            */
        }  
  }
/*
  public void AddPoint() {
        score += 1;
        scoreText.text = score.ToString() + " Points";
        SceneManager.LoadScene("Test_Map");
    }
*/  
}
