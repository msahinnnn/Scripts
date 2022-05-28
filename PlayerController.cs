using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 5.0f;
    float ballSpeed = 5.0f;
    Rigidbody ballRigidbody;
    Transform ballTransform;
 
    void Start()
    {
       ballRigidbody = GameObject.Find("Ball").GetComponent<Rigidbody>();
       ballTransform = GameObject.Find("Ball").GetComponent<Transform>();
    }

   
   
    void Update()
    {   
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        { 
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A)) { 
            transform.Rotate(0, -0.5f, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0.5f, 0);
        } 
    }  

    private void OnCollisionStay(Collision other) {
        if(other.gameObject.tag == "Ball"){
                
            if(Input.GetKey(KeyCode.Space)){
                
                float horizontal = Input.GetAxisRaw("Horizontal"); 
                float vertical = Input.GetAxisRaw("Vertical"); 

                Vector3 ballMovement = transform.TransformDirection(horizontal, 0.5f, vertical) * ballSpeed;

                ballRigidbody.AddForce(ballMovement, ForceMode.Impulse);

            }    
        
        
        }
        
    }


}

