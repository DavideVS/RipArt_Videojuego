using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickObra9 : MonoBehaviour
{
  // Update is called once per frame    
  void Update() {  
    if (Input.GetMouseButtonDown(0)) {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      RaycastHit hit;  
      if (Physics.Raycast(ray, out hit)) {  
        //Select stage    
        if (hit.transform.name == "workChoice21") {  //SphereGo - MonaLisaGoBack 
          SceneManager.LoadScene("Obra9_Scene"); //FrontObra
        }  
      }  
    }
  }  
}
