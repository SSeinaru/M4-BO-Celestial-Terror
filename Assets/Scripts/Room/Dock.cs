using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dock : MonoBehaviour
{
    
    public GameObject SceneChange;
    private RoomLogic roomLogic;

    public void Start()
    {
        roomLogic = GameObject.Find("ROoms").GetComponent<RoomLogic>();
        //roomChangeManager = new RoomChangeManager(SceneChange);
    }

    public void OnButtonPress()
    {
        roomLogic.MoveToRoom(SceneChange, Rooms.Docking, Rooms.Shuttle);
    }
    public void Innerbutton() 
    {
        roomLogic.MoveToRoom(SceneChange, Rooms.Docking, Rooms.Innercore);
    }
}
