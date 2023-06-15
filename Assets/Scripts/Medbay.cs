using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medbay : MonoBehaviour
{
    public GameObject innercore;
    public GameObject hallway;
    public GameObject medbay;
    // Start is called before the first frame update
    public void ButtonPressedInner()
    {
        medbay.SetActive(false);
        innercore.SetActive(true);
    }
    public void OnMouseUpAsButton()
    {
        medbay.SetActive(false);
        hallway.SetActive(true);
    }
}
