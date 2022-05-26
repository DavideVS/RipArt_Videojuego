using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickObra6 : MonoBehaviour
{
  // Update is called once per frame    
  void Update() {  
    if (Input.GetMouseButtonDown(0)) {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      RaycastHit hit;  
      if (Physics.Raycast(ray, out hit)) {  
        //Select stage    
        if (hit.transform.name == "workChoice12") {  //SphereGo - MonaLisaGoBack 
          SceneManager.LoadScene("Obra6_Scene"); //FrontObra
        }  
      }  
    }
  }  
}
