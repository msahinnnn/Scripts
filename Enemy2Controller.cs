using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controller : MonoBehaviour
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
            if(b.z >= -30f && b.z <= 0f) 
            {               
                transform.position = Vector3.MoveTowards(a, Vector3.Lerp(a, b, 0.1f),enemySpeed);
            
            }
            
        }
    }
    void Update()
    {
        
    }
}
