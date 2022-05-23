using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.transform.tag == "Enemigo") {
                //Debug.Log("Collision");
                Manager.gameOver = true;
            }
    }   
}
