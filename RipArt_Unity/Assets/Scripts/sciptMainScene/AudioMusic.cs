using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioMusic : MonoBehaviour
{
    static AudioMusic instance;

    void Awake() {
        if (instance != null) {
            Destroy(gameObject);
        }
        else {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Update() {  
        if (Input.GetMouseButtonDown(0)) {  
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
            RaycastHit hit;  
            if (Physics.Raycast(ray, out hit)) {  
            //Select stage    
            if (hit.transform.name == "MonaLisaGoBack") {  
                SceneManager.LoadScene("Obra1_Scene"); //FrontObra
            }  
            }  
        }
    }
}
