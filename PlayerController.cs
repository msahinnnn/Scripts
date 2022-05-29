using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 3.0f;
    float ballSpeed = 6.5f;
    Rigidbody ballRigidbody;
    Transform ballTransform;
    CharacterController playerController;
    Animator playerAnimator;
    Vector3 moveDirection;
    float moveRotation = 0;
    float moveRotationSpeed = 100;
 
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
        

        if(Input.GetKeyDown(KeyCode.A)){
            playerAnimator.SetBool("Running", true);
            moveDirection = transform.TransformDirection(horizontal, 0f, vertical) * speed;
        }
        if(Input.GetKeyUp(KeyCode.A)){
            moveDirection = new Vector3(0,0,0);
            playerAnimator.SetBool("Running", false);
        }

        moveRotation += horizontal*moveRotationSpeed*Time.deltaTime;
        transform.eulerAngles = new Vector3(0,moveRotation,0);
        playerController.Move(moveDirection*Time.deltaTime);


        // if (Input.GetKeyDown(KeyCode.A))
        // {
        //     playerAnimator.SetBool("Running", true);
        //     transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // }
        // if (Input.GetKeyUp(KeyCode.A))
        // {
        //     playerAnimator.SetBool("Running", false);
        // }


        // if (Input.GetKeyDown(KeyCode.D))
        // { 
        //     playerAnimator.SetBool("Running", true);
        //     transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
        // }
        // if (Input.GetKeyUp(KeyCode.D))
        // {
        //    playerAnimator.SetBool("Running", false);
        // }



        // if (Input.GetKeyDown(KeyCode.W)) { 
        //     playerAnimator.SetBool("Running", true);
        //     transform.Rotate(0, -5f, 0);
        // }
        // if (Input.GetKeyUp(KeyCode.W))
        // {
        //     playerAnimator.SetBool("Running", false);
        // }



        // if (Input.GetKeyDown(KeyCode.S))
        // {
        //     playerAnimator.SetBool("Running", true);
        //     transform.Rotate(0, 5f, 0);
        // }
        // if (Input.GetKeyUp(KeyCode.S))
        // {
        //     playerAnimator.SetBool("Running", false);
        // }


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

