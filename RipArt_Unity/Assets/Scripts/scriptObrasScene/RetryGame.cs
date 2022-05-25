using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour
{
    // Start is called before the first frame update    
  void Start() {}  
  
  // Update is called once per frame    
  void Update() {
    /*
    if (Input.GetMouseButtonDown(0)) {
        //gameOverPanel.SetActive(true);
            SceneManager.LoadScene("GameOverScene");
    }*/

    if (Input.GetMouseButtonDown(0)) {
            //Original.active = true;
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit)) {
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null) {
                    //Destroy(Original);
                    //Destroy(bc.gameObject);
                    SceneManager.LoadScene("GameOverScene");
                }
                /*else {
                  SceneManager.LoadScene("WinScene");
                }*/
            }
            /*
            Original = GameObject.FindWithTag ("Original");
            Destroy(Original);
            */
        }  
  }  
}

