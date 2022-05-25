using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.transform.tag == "Enemigo") {
                //Debug.Log("Collision");
                SceneManager.LoadScene("GameOverScene");
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                //Manager.gameOver = true;
                //gameObject.SetActive(false);
            }
    }   
}
