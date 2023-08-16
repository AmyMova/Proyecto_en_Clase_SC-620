using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timerText;
    [SerializeField]
    float remainingTime = 90.0F;
    bool _isRemainigTime;

    float _elapsedTime;


     void Start()
    {
        _isRemainigTime = remainingTime > 0.0F;

    }

     void Update()
    {
        if (_isRemainigTime)
        {
            remainingTime -= Time.deltaTime;
            if (remainingTime < 0.0F)
            {
                remainingTime = 0.0F;
            }
            int minutes = Mathf.FloorToInt(_elapsedTime / 60);
            int seconds = Mathf.FloorToInt(_elapsedTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            _elapsedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(_elapsedTime / 60);
            int seconds = Mathf.FloorToInt(_elapsedTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

    }
}
