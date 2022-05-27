using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public int myScore ;
    

    public void Update(){
        GameObject.Find("MyTeam").GetComponent<TextMesh>().text = myScore + "";

    }

    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.tag == "Goal"){
            Debug.Log("GOOOOLLLL");
            transform.position = GameObject.Find("BallPosition").transform.position;
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            
            GameObject.Find("Player").transform.position = GameObject.Find("PlayerPosition").transform.position;

            myScore += 1;
        }

        if(other.gameObject.tag == "TouchLine"){
            Debug.Log("OUT!");

            transform.position = GameObject.Find("BallPosition").transform.position;
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            
            GameObject.Find("Player").transform.position = GameObject.Find("PlayerPosition").transform.position;
        }
    }




}
