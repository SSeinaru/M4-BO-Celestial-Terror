using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observe : MonoBehaviour
{
    public GameObject bserve;
    public GameObject inner;

    public AudioSource FootSteps;
    // Start is called before the first frame update
    public void OnClick()
    {
        bserve.SetActive(false);
        inner.SetActive(true);
    }
}
