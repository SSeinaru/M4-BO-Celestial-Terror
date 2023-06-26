  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeline : MonoBehaviour
{
    float[] rotations = { 0, 90, 180, 270 };
    public float correctRotation;
    [SerializeField]
    bool isplaced = false;

    float possiblerotion = 1;
    PipeManager pipeManager;
    private void Awake()
    {
            pipeManager = GameObject.Find("PipeManager").GetComponent<PipeManager>();
    }
    private void Start()
    {
        //possiblerotion = correctRotation;
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
        //transform.Rotate(new Vector3(0, 0, 90));
        Debug.Log(correctRotation + " " + name);
        if(possiblerotion >= 1)
        {
            isplaced = (int)transform.eulerAngles.z == (int)correctRotation;
            // if (transform.eulerAngles.z == correctRotation)
            // {
            //    // Debug.Log("correct " + transform.position + " " + transform.eulerAngles.z + " " + correctRotation);
            //
            //     isplaced = true;
            //     //pipeManager.correctMove();
            // }
            // else
            // {
            //    // Debug.Log("fout " + transform.position + " " + transform.eulerAngles.z + " " + correctRotation);
            //
            //     isplaced = false;
            //     //pipeManager.wrongMove();
            // }

        }
       
        
    }
    public void OnMouseDown()
    {
        if (possiblerotion >= 1)
        {
            
            transform.Rotate(new Vector3(0, 0, 90));

            Debug.Log(correctRotation + " " + name);
            isplaced = (int)transform.eulerAngles.z == (int)correctRotation;
          // if (transform.eulerAngles.z == correctRotation && isplaced == false)
          // {
          //     isplaced = transform.eulerAngles.z == correctRotation;
          //    // Debug.Log("correct "+transform.position + " " + transform.eulerAngles.z + " " + correctRotation);
          //    // pipeManager.correctMove();
          // }
          // else if (isplaced == true)
          // {
          //     Debug.Log("fout " + transform.position + " " + transform.eulerAngles.z + " " + correctRotation);
          //
          //     isplaced = false;
          //    // pipeManager.wrongMove();
          //
          //
          // }
            pipeManager.CheckSolution();

        }
   
    }

    internal bool IsCorrect()
    {
        return isplaced;
    }
}
