using UnityEngine;
using TMPro;
using System;

public class TimerScript : MonoBehaviour
{
    public float timerDuration = 60f; // The duration of the timer in seconds
    private float timer; // The current value of the timer
    private TextMeshProUGUI textMeshProUGUI; // Reference to the TextMeshProUGUI component

    private void Start()
    {
        // Get the TextMeshProUGUI component attached to the same GameObject
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        StartTimer();
    }

    private void Update()
    {
        if (timer > 0f)
        {
            // Update the timer value and display it
            timer -= Time.deltaTime;
            textMeshProUGUI.text = FormatTime(timer);

            // Check if the timer has reached zero
            if (timer <= 0f)
            {
                timer = 0f;
                Debug.Log("death");
            }
        }
    }

    public void StartTimer()
    {
        timer = timerDuration;
    }

    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}