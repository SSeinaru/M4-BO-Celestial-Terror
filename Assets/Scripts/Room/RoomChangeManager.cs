using System.Threading.Tasks;
using UnityEngine;
public enum ChangeStates { START, MIDDLE, END }
public enum Rooms { Shuttle, Docking, Innercore, Hydroponics, Box, BoxOpen, Hallway, Airlock, Medbay, Observe }

public class RoomChangeManager
{
    private Rooms fromRoom, toRoom;
    public float timerDuration = 2f;
    private ChangeStates changeStates = ChangeStates.END;
    public float timer;
    private GameObject SceneChange;
    public RoomChangeManager(GameObject sceneChange)
    {
        this.SceneChange= sceneChange;
    }

    public void MoveToRoom(Rooms from, Rooms to)
    {
        if (changeStates != ChangeStates.END)
        {
            return;
        }
        this.fromRoom = from;
        this.toRoom = to;
        // StartTimer();
        timer = timerDuration;
        SceneChange.SetActive(true);
        changeStates = ChangeStates.START;

        Task.Run(() => {

            while (changeStates != ChangeStates.END)
            {
                Update(Time.deltaTime);
            }
        });
        //do room change
    }

    internal void Update(float deltaTime)
    {

        if (changeStates != ChangeStates.END)
        {
            timer -= Time.deltaTime;
            Debug.Log(timer + " " + changeStates);
            if (timer <= 0f && changeStates != ChangeStates.END)
            {
                timer = 0f;
                SceneChange.SetActive(false);
                changeStates = ChangeStates.END;
            }

            else if (timer <= 1f && changeStates != ChangeStates.MIDDLE)
            {
                GameObject all = GameObject.Find("ROoms");


                GameObject fromRoomL = all.transform.Find(fromRoom.ToString()).gameObject;
                GameObject targetRoom = all.transform.Find(toRoom.ToString()).gameObject;
                Debug.Log(fromRoomL + " " + targetRoom);
                targetRoom.SetActive(true);
                fromRoomL.SetActive(false);
                changeStates = ChangeStates.MIDDLE;
            }
        }
    }
}
