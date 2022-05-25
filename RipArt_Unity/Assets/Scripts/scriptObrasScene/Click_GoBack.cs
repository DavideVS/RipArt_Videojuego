using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click_GoBack : MonoBehaviour
{
    // Start is called before the first frame update    
  void Start() {}  
  
  // Update is called once per frame    
  void Update() {
    if (Input.GetMouseButtonDown(0)) {
        //gameOverPanel.SetActive(true);
            SceneManager.LoadScene("Test_Map");
    } 
    /* 
    if (Input.GetMouseButtonDown(0)) {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      RaycastHit hit;  
      if (Physics.Raycast(ray, out hit)) {  
  
        //Select stage    
        if (hit.transform.name == "SphereOut") {  
          SceneManager.LoadScene("Test_Map");  
        }  
      }  
    }*/
    /*
    if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

            if (Physics.Raycast(ray, out hit)) {
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null) {
                    Destroy(bc.gameObject);
                    //Destroy(bc.gameObject("ObraCortada"));
                }
            }
        }    
    */
  }  
}
