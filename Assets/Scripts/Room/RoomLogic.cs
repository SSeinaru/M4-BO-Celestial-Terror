using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLogic : MonoBehaviour
{
    public RoomChangeManager roomChangeManager;//

    internal void MoveToRoom(GameObject SceneChange,Rooms from, Rooms to)
    {
        roomChangeManager = new RoomChangeManager(SceneChange);
        roomChangeManager.MoveToRoom(from, to);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (roomChangeManager != null)
        {
            roomChangeManager.Update(Time.deltaTime);
        }
    }
}
