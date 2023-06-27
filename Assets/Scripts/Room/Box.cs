using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject box;
    public GameObject hydro;
    public GameObject boxOpen;

    public GameObject SceneChange;
    
    public  void HydroReturn()
    {
        box.SetActive(false);
        hydro.SetActive(true);
    }
    public void BoxOpen()
    {
        box.SetActive(false);
        boxOpen.SetActive(true);
    }
}
