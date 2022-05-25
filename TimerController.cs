using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerController : MonoBehaviour
{
    public Text timerText;
    private float starTime;

    void Start() {
        starTime = Time.time ;
    }
    void Update() {
        float t = Time.time - starTime;
        

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f1");

        timerText.text = "90 / " + minutes + " : " + seconds;
        if(minutes.ToString() == "0" & seconds.ToString() == "9"){
            Debug.Log("bitti.");
        }
    }
}
