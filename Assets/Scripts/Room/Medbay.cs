using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medbay : MonoBehaviour
{
    public GameObject hallway;
    public GameObject medbay;

    public GameObject SceneChange;

    // Start is called before the first frame update
    public void BackHallway()
    {
        medbay.SetActive(false);
        hallway.SetActive(true);
    }
}
