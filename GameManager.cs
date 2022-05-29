using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    //public TextMeshProUGUI ballText;
    public TextMeshProUGUI ScoreText;
    int timeMinutes = 79;
    int timeSeconds = 50;
    // public bool goalTriger;
    // public bool outTrigger;
    // string state;
    void Start()
    {
        //StartCoroutine(GameTimer());
        InvokeRepeating("GameTimer", 0f, 1f);
        
    }
  
    void Update()
    {
        // goalTriger = GameObject.Find("Ball").GetComponent<BallController>().isGoal;
        // outTrigger = GameObject.Find("Ball").GetComponent<BallController>().isOut;
        // if(goalTriger){
        //     state = "GOAL !!!";
        // }
        // if(outTrigger){
        //     state = "OUT !";
        // }

        // Invoke("BallState", 0f);
        int score = GameObject.Find("Ball").GetComponent<BallController>().myScore;
        ScoreText.text = "RAKİP 2 | BEN " + score.ToString();
        
    }

    public void ChangeScene(int sceneId){
        SceneManager.LoadScene(sceneId);
    }

    

    public void GameTimer(){
        if(timeSeconds == 59){
            timeMinutes++;
            timeSeconds = 00;
        }
        timeSeconds++;
        //goalTriger = false;
        //outTrigger = false;
        //Debug.Log(timeMinutes + " - " + timeSeconds);
        string min = timeMinutes.ToString();
        string sec = timeSeconds.ToString();
        timeText.text = min + ":" + sec;
        if(timeMinutes == 81 ){
            Debug.Log("Game Over");
            CancelInvoke("GameTimer");
            ChangeScene(2);           
        }
    }

    
}


