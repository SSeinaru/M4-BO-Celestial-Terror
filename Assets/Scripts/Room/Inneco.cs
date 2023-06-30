using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inneco : MonoBehaviour
{
    public GameObject SceneChange;
    private RoomLogic roomLogic;

    public void Start()
    {
        roomLogic = GameObject.Find("ROoms").GetComponent<RoomLogic>();
        //roomChangeManager = new RoomChangeManager(SceneChange);
    }
    public void ToDocking()
    {
        roomLogic.MoveToRoom(SceneChange, Rooms.Innercore, Rooms.Docking);
    }
    public void ToObserve()
    {
        roomLogic.MoveToRoom(SceneChange, Rooms.Innercore, Rooms.Observe);
    }
    public void ToHallway()
    {
        roomLogic.MoveToRoom(SceneChange, Rooms.Innercore, Rooms.Hallway);
    }
    public void ToHydroponics()
    {
        roomLogic.MoveToRoom(SceneChange, Rooms.Innercore, Rooms.Hydroponics);
    }
}
