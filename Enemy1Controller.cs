using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Controller : MonoBehaviour
{
    CharacterController enemyController;
    Animator enemyAnimator;
    Vector3 moveDirection;
    float moveRotation = 0;
    float moveRotationSpeed = 100;
    public Transform ball;
    float enemySpeed = 0.1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate() {
        //enemyAnimator.SetBool("Running", true);
        Vector3 a = transform.position;
        Vector3 b = ball.position;
        
        if(b.x >= -24.0f && b.x <= 34.0f)
        {
            if(b.z >= 0f && b.z <= 30.0f) 
            {               
                transform.position = Vector3.MoveTowards(a, Vector3.Lerp(a, b, 0.1f),enemySpeed);
            
            }
            
        }
    }


    // void Update()
    // {  
    //     float xPos = ball.position.x;
    //     float zPos = ball.position.z;

    //     if(xPos >= -24.0f && xPos <= 34.0f)
    //     {
    //         if(zPos >= 0f && zPos <= 30.0f) 
    //         {
    //             enemyAnimator.SetBool("Running", true);
    //             moveDirection = transform.TransformDirection(zPos, 0f, xPos) * enemySpeed;
    //             moveRotation += zPos*moveRotationSpeed*Time.deltaTime;
    //             transform.eulerAngles = new Vector3(0,moveRotation,0);
    //             enemyController.Move(moveDirection*Time.deltaTime);

                
                
    //         }
    //         else{
    //              enemyAnimator.SetBool("Running", false);
    //              moveDirection = new Vector3(0,0,0);
    //         }
                

    //     }       
        
    // }
}
