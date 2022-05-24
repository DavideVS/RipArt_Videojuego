using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collaider : MonoBehaviour
{
    [SerializeField]
    float walkSpeed;
    [SerializeField]
    float jumpForce;
    /*
    enum States {IDLE, JUMPING, FALLING, MAX_STATES };
    States state = States.IDLE;
    */
    Rigidbody  rigidBody;
    float yPos;

    // Start is called before the first frame update
    void Start(){
         //define the animator attached to the player
        rigidBody = GetComponent<Rigidbody>();
        yPos      = transform.position.y;
    }

    private void FixedUpdate() {
           rigidBody.AddForce(Input.GetAxis("Vertical") * walkSpeed, 0.0f,
                               Input.GetAxis("Horizontal") * walkSpeed);
    }

    // Update is called once per frame
    void Update(){
        
    }
}
