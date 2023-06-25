using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airlock : MonoBehaviour
{
    public GameObject airlockDis;
    public GameObject hallway;

    public AudioSource FootSteps;
    // Start is called before the first frame update

    public void OnClick()
    {
        airlockDis.SetActive(false);
        hallway.SetActive(true);
    }
}
