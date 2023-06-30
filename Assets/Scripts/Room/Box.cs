using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject box;
    public GameObject boxOpen;

    public GameObject SceneChange;
    private RoomLogic roomLogic;

    // Start is called before the first frame update
    public void Start()
    {
        roomLogic = GameObject.Find("ROoms").GetComponent<RoomLogic>();
        //roomChangeManager = new RoomChangeManager(SceneChange);
    }
    public  void ReturnToHydro()
    {
        roomLogic.MoveToRoom(SceneChange, Rooms.Box, Rooms.Hydroponics);
    }
    public void BoxOpen()
    {
        box.SetActive(false);
        boxOpen.SetActive(true);
    }
}
