  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeline : MonoBehaviour
{
    float[] rotations = { 0, 90, 180, 270 };
    public float[] correctRotation;
    [SerializeField]
    bool isplaced = false;

    int possiblerotion = 1;
    PipeManager pipeManager;
    private void Awake()
    {
            pipeManager = GameObject.Find("PipeManager").GetComponent<PipeManager>();
    }
    private void Start()
    {
        possiblerotion = correctRotation.Length;
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
        transform.Rotate(new Vector3(0, 0, 90));

        if(possiblerotion > 1)
        {
            if (transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1])
            {
                isplaced = true;
                pipeManager.correctMove();
            }
            else
            {
                if (transform.eulerAngles.z == correctRotation[0])
                {
                    isplaced = true;
                    pipeManager.correctMove();
                }
            }

        }
       
        
    }
    public void OnMouseDown()
    {
        if (possiblerotion > 1)
        {
            transform.Rotate(new Vector3(0, 0, 90));
            if (transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1] && isplaced == false)
            {
                isplaced = true;
                pipeManager.correctMove();
            }
            else if (isplaced == true)
            {
                isplaced = false;
                pipeManager.wrongMove();

            }
            else
            {
                transform.Rotate(new Vector3(0, 0, 90));
                if (transform.eulerAngles.z == correctRotation[0] && isplaced == false)
                {
                    isplaced = true;
                    pipeManager.correctMove();
                }
                else if (isplaced == true)
                {
                    isplaced = false;
                    pipeManager.wrongMove();

                }
            }
        }
    }
}
