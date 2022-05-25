using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public int myScore ;
    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.tag == "Goal"){
            Debug.Log("GOOOOLLLL");
            transform.position = GameObject.Find("BallPosition").transform.position;
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

            myScore += 1;
        }
    }

    public void Update(){
        GameObject.Find("MyTeam").GetComponent<TextMesh>().text = myScore + "";

    }


}
