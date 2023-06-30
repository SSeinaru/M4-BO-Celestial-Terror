using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observe : MonoBehaviour
{
    public GameObject SceneChange;
    private RoomLogic roomLogic;

    // Start is called before the first frame update
    public void Start()
    {
        roomLogic = GameObject.Find("ROoms").GetComponent<RoomLogic>();
        //roomChangeManager = new RoomChangeManager(SceneChange);
    }
    public void ToInnercore()
    {
        roomLogic.MoveToRoom(SceneChange, Rooms.Hallway, Rooms.Innercore);
    }
}
