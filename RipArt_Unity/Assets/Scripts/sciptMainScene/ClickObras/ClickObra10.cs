using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickObra10 : MonoBehaviour
{
  // Update is called once per frame    
  void Update() {  
    if (Input.GetMouseButtonDown(0)) {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      RaycastHit hit;  
      if (Physics.Raycast(ray, out hit)) {  
        //Select stage    
        if (hit.transform.name == "workChoice22") {  //SphereGo - MonaLisaGoBack 
          SceneManager.LoadScene("Obra10_Scene"); //FrontObra
        }  
      }  
    }
  }  
}
