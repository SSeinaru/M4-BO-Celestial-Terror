using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Halway : MonoBehaviour
{
    public GameObject SceneChange;
    private RoomLogic roomLogic;

    public void Start()
    {
        roomLogic = GameObject.Find("ROoms").GetComponent<RoomLogic>();
        //roomChangeManager = new RoomChangeManager(SceneChange);
    }

    public void ToAirlock()
    {
        roomLogic.MoveToRoom(SceneChange, Rooms.Hallway, Rooms.Airlock);
    }
    public void ToMedbay()
    {
        roomLogic.MoveToRoom(SceneChange, Rooms.Hallway, Rooms.Medbay);
    }
    public void ToInnercore()
    {
        roomLogic.MoveToRoom(SceneChange, Rooms.Hallway, Rooms.Innercore);
    }
}
