using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dock : MonoBehaviour
{
    public GameObject shuttle;
    public GameObject dock;
    public GameObject innercore;

    public GameObject SceneChange;

    public void ArrowPressShuttle()
    {
        dock.SetActive(false);
        shuttle.SetActive(true);
    }

    public void ArrowPressInner()
    {
        dock.SetActive(false);
        innercore.SetActive(true);
    }
}
