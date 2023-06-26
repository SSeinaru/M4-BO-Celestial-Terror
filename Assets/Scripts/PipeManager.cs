using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    public GameObject pipesHolder;
    public GameObject[] pipes;
    public GameObject incorrectpipe;
    public GameObject Timer;

    [SerializeField]
    int totalPipes = 0;
    [SerializeField]
    int correctpipes = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        totalPipes = pipesHolder.transform.childCount;

        pipes = new GameObject[totalPipes];
        for (int i =0; i< totalPipes; i++)
        {
            pipes[i] =pipesHolder.transform.GetChild(i).gameObject;
        }
        
    }

   public void correctMove()
   {
        correctpipes += 1;
        Debug.Log("correct move");
        Debug.Log(correctpipes + " T "+ totalPipes);
        if (correctpipes == totalPipes)
        {
            Debug.Log("you win");
        }
   }

    public void wrongMove()
    {
        correctpipes -= 1;
        Debug.Log(correctpipes);

    }

    internal void CheckSolution()
    {

        pipeline[] pips = GetComponentsInChildren<pipeline>();
        bool check = true;
        foreach (pipeline pip in pips)
        {
            Debug.Log(pip.IsCorrect() + " " + pip.name +  " "+pip.correctRotation + " "+ pip.transform.eulerAngles.z);
            if (pip.IsCorrect() ==false)
            {
                check = false;
            }
        }
        if (check)
        {
            Timer.SetActive(false);
        }
    }
}

