using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public int myScore ;

    public void Update(){
        

    }
   
    private void OnTriggerEnter(Collider other) {       
        
        if(other.gameObject.tag == "Goal"){
            Debug.Log("GOOOOLLLL");


            transform.position = GameObject.Find("BallPosition").transform.position;
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            
            GameObject.Find("Player").transform.position = GameObject.Find("PlayerPosition").transform.position;

            myScore += 1; 

                
        }

        if(other.gameObject.tag == "Wall"){
            Debug.Log("OUT!");


            transform.position = GameObject.Find("BallPosition").transform.position;
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            
            GameObject.Find("Player").transform.position = GameObject.Find("PlayerPosition").transform.position;

              
        }
    
    }
        

}
