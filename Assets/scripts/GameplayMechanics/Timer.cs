using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool digital;
    public float timeAllowed;
    private float maxTime;
    private bool timerOn = true;
    private Text timer;
    private Transform minHand;
    private Transform hourHand;
    public float miniMinAngle;
    public float maxMinAngle;
    public float miniHourAngle;
    public float maxHourAngle;

    private void Start()
    {
        maxTime = timeAllowed;
        if (digital)
        {
            timer = gameObject.GetComponent<Text>();
        }
        else
        {
            minHand = gameObject.transform.Find("MinuteHand").transform;
            hourHand = gameObject.transform.Find("HourHand").transform;
            minHand.eulerAngles = new Vector3(0, 0, miniMinAngle);
            hourHand.eulerAngles = new Vector3(0, 0, miniHourAngle);
        }
    }

    void Update()
    {
        if (timerOn)
        {
            if (timeAllowed > 0)
            {
                UpdateTime();
            }
            else
            {
                TimeUp();
            }
        }
    }

    
    private void UpdateTime()
    {
        timeAllowed -= Time.deltaTime;
        float minutes = Mathf.FloorToInt(timeAllowed / 60);
        float seconds = Mathf.FloorToInt(timeAllowed % 60);
        ChangeClock(minutes, seconds);
    }

    private void ChangeClock(float min, float sec)
    {
        if (digital)
        {
            timer.text = string.Format("{0:00} : {1:00}", min, sec);
        }
        else
        {
            minHand.Rotate(0, 0, (maxMinAngle - miniMinAngle) / maxTime);
            hourHand.Rotate(0, 0, (maxHourAngle - miniHourAngle) / maxTime);
        }
    }

    private void TimeUp()
    {
        timerOn = false;
        Debug.Log("Time's up.");
    }
}