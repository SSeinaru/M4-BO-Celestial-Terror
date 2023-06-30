using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medbay : MonoBehaviour
{


    public GameObject SceneChange;
    private RoomLogic roomLogic;

    // Start is called before the first frame update
    public void Start()
    {
        roomLogic = GameObject.Find("ROoms").GetComponent<RoomLogic>();
        //roomChangeManager = new RoomChangeManager(SceneChange);
    }
    public void ReturnToHallway()
    {
        roomLogic.MoveToRoom(SceneChange, Rooms.Medbay, Rooms.Hallway);

    }
}
