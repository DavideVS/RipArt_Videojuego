using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickObra1 : MonoBehaviour
{
  /*
  static ClickObra1 instance;

    void Awake() {
        if (instance != null) {
            Destroy(gameObject);
        }
        else {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
  */
  // Update is called once per frame    
  void Update() {  
    if (Input.GetMouseButtonDown(0)) {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      RaycastHit hit;  
      if (Physics.Raycast(ray, out hit)) {  
        //Select stage    
        if (hit.transform.name == "workChoice") {  //SphereGo - MonaLisaGoBack 
          SceneManager.LoadScene("Obra1_Scene"); //FrontObra
        }  
      }  
    }
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
