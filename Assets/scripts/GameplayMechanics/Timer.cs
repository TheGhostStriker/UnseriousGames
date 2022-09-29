using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool digital; //Whether you want the time to be displayed as a number or as the hands of a physical clock.
    public float timeAllowed; //The total time the player is given to complete the task in seconds.
    private float maxTime; //The value timeAllowed starts at. This is set automatically.
    private bool timerOn = true; //Whether or not the timer is running.
    private Text timer; //The text coponent for the digital option.
    private Transform minHand; //The minute hand child object. Move the hand's pivot to the base of the hand.
    private Transform hourHand; //The hour hand child object. Move the hand's pivot to the base of the hand.
    public float miniMinAngle; //The rotation value minute hand starts at.
    public float maxMinAngle; //The rotation value minute hand ends at.
    public float miniHourAngle; //The rotation value hour hand starts at.
    public float maxHourAngle; //The rotation value hour hand ends at.

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
            //This sets the hands to their starting rotatons.
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
        float minutes = Mathf.FloorToInt(timeAllowed / 60); //This divides the current time intominutes and seconds.
        float seconds = Mathf.FloorToInt(timeAllowed % 60);
        ChangeClock(minutes, seconds);
    }

    private void ChangeClock(float min, float sec)
    {
        if (digital)
        {
            timer.text = string.Format("{0:00} : {1:00}", min, sec); //Formats the minutes and seconds into a digital display.
        }
        else
        {
            //This attempts to move the hands by a realtive amount when time passes.
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