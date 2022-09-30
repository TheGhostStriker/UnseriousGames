using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCountdown : MonoBehaviour
{

    public float timeRemaining = 6000;
    public bool timerIsRunning = false;
    public Text timeText;


    // Start is called before the first frame update
    
    
   
    
    
    void Start()
    {
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining >= 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);

            }
            else
            {
                Debug.Log("Time has run out");
                timeRemaining = 0;
                timerIsRunning = false;
                SceneManager.LoadScene("YOU GOT FIRED BISH");
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
