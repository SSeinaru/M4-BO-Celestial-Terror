using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydro : MonoBehaviour
{
    public GameObject innerCore;
    public GameObject hydroPonics;
    public GameObject puzzle1;

    public AudioSource FootSteps;
    // Start is called before the first frame update

    public void onArrowPress()
    {
        hydroPonics.SetActive(false);
        innerCore.SetActive(true);
    }
    public void onEboxpress()
    {
        hydroPonics.SetActive(false) ;
        puzzle1.SetActive(true) ;
    }

}
