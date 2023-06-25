using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shuttle: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shuttle;
    public GameObject dock;
    public AudioSource FootSteps;

    public void OnButtonPress()
    {
        dock.SetActive(true);
        shuttle.SetActive(false);
        FootSteps.Play();
    }
}
