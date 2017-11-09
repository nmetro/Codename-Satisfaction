using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTextScript : MonoBehaviour {
    public Text timeText;

    private float localTime = 0;
    private int seconds = 0, minutes = 0, hours = 0, days = 0;
    private string sSeconds = "", sMinutes = "", sHours = "", sDays = "";

    // Update is called once per frame
    void Update()
    {
        localTime += Time.deltaTime;
        if (localTime > 1)
        {
            localTime--;
            seconds++;
            if (seconds > 59)
            {
                minutes++;
                seconds -= 60;
                if (minutes > 59)
                {
                    hours++;
                    minutes -= 60;
                    if (hours > 23)
                    {
                        days++;
                        hours -= 24;
                    }
                }
            }
            if (seconds > 0)
            {
                sSeconds =  " " + seconds.ToString() + " second";
                if (seconds > 1) sSeconds += "s";
            } else sSeconds = "";
            if (minutes > 0)
            {
                sMinutes = " " + minutes.ToString() + " minute";
                if (minutes > 1) sMinutes += "s";
            }
            else sMinutes = "";
            if (hours > 0)
            {
                sHours = " " + hours.ToString() + " hour";
                if (hours > 1) sHours += "s";
            }
            else sHours = "";
            if (days > 0)
            {
                sDays = " " + days.ToString() + " day";
                if (days > 0) sDays += "s";
            }
            else sDays = "";
            timeText.text = "Time:" + sDays + sHours+ sMinutes + sSeconds;
        }
    }
}
