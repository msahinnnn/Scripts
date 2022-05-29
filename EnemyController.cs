using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Vector3 ballPosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ballPosition = GameObject.Find("Ball").GetComponent<Transform>().position;
        float xPos = ballPosition.x;
        float zPos = ballPosition.z;

        if(xPos >= -24.0f && xPos <= 34.0f)
        {
            if(zPos >= 0f && zPos <= 30.0f) 
            {
                Debug.Log("ALAN 1");
            }
            if(zPos >= -30.0f && zPos <= 0f) 
            {
                Debug.Log("ALAN 2");
            }
        }
        
    }
}
