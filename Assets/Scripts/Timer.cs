using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timerToComplete = 30f;
    [SerializeField] float timerToShow = 10f;

    public bool isAnsweringQuestion = false;
    public float fillFraction;
    public bool loadNetQuestion;

    float timerValue;
    void Update()
    {
        updateTiemr();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void updateTiemr()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timerToComplete;
            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timerToShow;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timerToShow;
            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timerToComplete;
                loadNetQuestion = true;
            }
        }
    }
}
