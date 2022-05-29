using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timeText;
    int timeMinutes = 79;
    int timeSeconds = 50;
    void Start()
    {
        //StartCoroutine(GameTimer());
        InvokeRepeating("GameTimer", 0f, 1f);
    }

    
    void Update()
    {
        
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
        Debug.Log(timeMinutes + " - " + timeSeconds);

        if(timeMinutes == 120 ){
            Debug.Log("Game Over");
            CancelInvoke("GameTimer");
            ChangeScene(2);           
        }
    }


}
