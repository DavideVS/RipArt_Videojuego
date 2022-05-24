using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {
    
    [SerializeField]
    Vector3 velocidad;
    // Start is called before the first frame update
    void Start() {
        //velocidad = new Vector3(1.0f, 2.0f, 3.0f);
    }

    // Update is called once per frame
    void Update() {
        //transform.Translate (new Vector3 (0.0f,0.0f,Input.GetAxis("Vertical") * velocidad.z) * Time.deltaTime);
        //transform.Translate (new Vector3 (Input.GetAxis("Horizontal") * Time.deltaTime, 0.0f,0.0f));
        transform.Translate (new Vector3((Input.GetAxis("Horizontal")*velocidad.z)*Time.deltaTime,
                                          0.0f,
                                          Input.GetAxis("Vertical")*velocidad.z)*Time.deltaTime, 0.0f);
        //transform.Rotate(angularSpeed * Time.deltaTime);
    }
}
