using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOpen : MonoBehaviour
{
    public GameObject boxClosed;
    public GameObject boxOpen;
    // Start is called before the first frame update
    public void OnClick()
    {
        boxClosed.SetActive(true);
        boxOpen.SetActive(false);
    }
}
