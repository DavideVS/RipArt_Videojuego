using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursuit : MonoBehaviour
{
    public Transform player;
    public float speedEnemy;
    public float distanceEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance (transform.position, player.transform.position);
        
        if (distance <= distanceEnemy)
        {
            transform.LookAt (player);
            transform.position = Vector3.Lerp(transform.position, player.transform.position, speedEnemy/100000);
        }
        
    }
}
