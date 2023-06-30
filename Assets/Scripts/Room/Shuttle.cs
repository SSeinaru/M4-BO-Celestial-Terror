using System;
using UnityEngine;


public class Shuttle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shuttle;
    public GameObject dock;
    private RoomLogic roomLogic;
    //private RoomChangeManager roomChangeManager;//
    public GameObject SceneChange;


    public void Start()
    {
        roomLogic= GameObject.Find("ROoms").GetComponent<RoomLogic>();
        //roomChangeManager = new RoomChangeManager(SceneChange);
    }

    public void OnButtonPress()
    {
        roomLogic.MoveToRoom(SceneChange, Rooms.Shuttle, Rooms.Docking);
    }
}
