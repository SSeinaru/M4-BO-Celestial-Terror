using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shuttle: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shuttle;
    public GameObject dock;

    public float timerDuration = 2f;
    public float timer;
    public GameObject SceneChange;

    public void OnButtonPress()
    {
        StartTimer();

        if (timer == 2f)
        {
            SceneChange.SetActive(true);
            timer -= Time.deltaTime;
        }
        if (timer == 1f)
        {
            dock.SetActive(true);
            shuttle.SetActive(false);
        }
        if (timer <= 0f || timer == 0)
        {
            timer = 0f;
            SceneChange.SetActive(false);
        }
    }

        public void StartTimer()
    {
        timer = timerDuration;
    }
}
