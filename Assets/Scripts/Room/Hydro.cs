using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydro : MonoBehaviour
{

    public GameObject SceneChange;

    private RoomLogic roomLogic;

    // Start is called before the first frame update
    public void Start()
    {
        roomLogic = GameObject.Find("ROoms").GetComponent<RoomLogic>();
        //roomChangeManager = new RoomChangeManager(SceneChange);
    }
    public void ReturnToInner()
    {
        roomLogic.MoveToRoom(SceneChange, Rooms.Hydroponics, Rooms.Innercore);

    }
    public void GoToBox()
    {
        roomLogic.MoveToRoom(SceneChange, Rooms.Hydroponics, Rooms.Box);
    }

}
