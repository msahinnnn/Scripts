using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

 
    //Default olarak karaktere bir hız verildi.
    float speed = 5.0f;
    Rigidbody rb;
    

    void Start()
    {
        
    }

    void Awake(){
        rb = GetComponent<Rigidbody>();
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
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
        } 
    }  

    private void OnCollisionStay(Collision other) {
        if(other.gameObject.tag == "Ball"){
    
            if(Input.GetKey(KeyCode.Space)){
                //GameObject.Find("Ball").transform.Translate();
            }    
        
        
        }
        
    }


}

