using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public float timerDuration = 60f; // The duration of the timer in seconds
    private float timer; // The current value of the timer
    public TextMeshProUGUI textMeshProUGUI; // Reference to the TextMeshProUGUI component

    private void Start()
    {
        Debug.Log("Start timer" );
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
           // Debug.Log(textMeshProUGUI);
            textMeshProUGUI.text = FormatTime(timer);

            // Check if the timer has reached zero
            if (timer <= 0f)
            {
                timer = 0f;
                SceneManager.LoadScene(2);
            }
        }
    }

    public void StartTimer()
    {
        timer = timerDuration;
    }

    private string FormatTime(float time)
    {
        int seconds = Mathf.FloorToInt(time % 60f);
        return string.Format("{00}", seconds);
    }
}