using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 1.0f;
    float ballSpeed = 4.5f;
    Rigidbody ballRigidbody;
    Transform ballTransform;
    CharacterController playerController;
    Animator playerAnimator;
    Vector3 moveDirection;
    float moveRotation = 0;
    float moveRotationSpeed = 100;
    float moveDirectionMagnitude = 0.5f;
 
    void Start()
    {
       ballRigidbody = GameObject.Find("Ball").GetComponent<Rigidbody>();
       ballTransform = GameObject.Find("Ball").GetComponent<Transform>();
       playerController = GetComponent<CharacterController>();
       playerAnimator = GetComponent<Animator>();
    }

   
   
    void Update()
    {   
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical");
        

        if(Input.GetKeyDown(KeyCode.W)){
            playerAnimator.SetBool("Running", true);
            moveDirection = transform.TransformDirection(horizontal, 0f, vertical) * speed;
        }
        if(Input.GetKeyUp(KeyCode.W)){
            moveDirection = new Vector3(0,0,0);
            playerAnimator.SetBool("Running", false);
        }


        moveRotation += horizontal*moveRotationSpeed*Time.deltaTime;
        transform.eulerAngles = new Vector3(0,moveRotation,0);
        playerController.Move(moveDirection*Time.deltaTime);

    }  

    
    private void OnControllerColliderHit(ControllerColliderHit hit) {
        
        if(hit.gameObject.tag == "Ball")
        {
            Rigidbody rigidbody = hit.collider.attachedRigidbody;
            Vector3 moveDirection = hit.gameObject.transform.position - transform.position;
            moveDirection.y = 0;
            moveDirection.Normalize();
            rigidbody.AddForceAtPosition(moveDirection*moveDirectionMagnitude, transform.position, ForceMode.Impulse);

            float horizontal = Input.GetAxisRaw("Horizontal"); 
            float vertical = Input.GetAxisRaw("Vertical");

            if(Input.GetKey(KeyCode.Space)){
                playerAnimator.SetTrigger("Shoot");
                Vector3 ballMovement = transform.TransformDirection(horizontal, 0.5f, vertical) * ballSpeed;
                ballRigidbody.AddForce(ballMovement, ForceMode.Impulse);

            }    
        
        
       }

    }
}
    




