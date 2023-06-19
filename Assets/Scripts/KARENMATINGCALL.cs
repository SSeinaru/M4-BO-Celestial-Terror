using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KARENMATINCALL : MonoBehaviour
{
    public GameObject pipesHolder;
    public GameObject[] pipes;

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
        correctpipes+= 1;
        if (correctpipes == totalPipes)
            Debug.Log("correct move");
        {
            Debug.Log("you win");
        }
    }
    public void wrongMove()
    {
        correctpipes-= 1;

    }

}

