using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public GameObject PipesHolder;
    public GameObject[] Pipes;
    public GameObject Hint;

    [SerializeField]
    int totalPipes = 0;
    [SerializeField]
    int correctPipes = 0;
    // Start is called before the first frame update
    void Start()
    {
        totalPipes = PipesHolder.transform.childCount;

        Pipes = new GameObject[totalPipes];

        for (int i = 0; i < Pipes.Length; i++)
        {
            Pipes[i] = PipesHolder.transform.GetChild(i).gameObject;
        }
    }

    public void correctMove()
    {
        correctPipes += 1;

        if(correctPipes == totalPipes)
        {
            Debug.Log("correct");
        }
    }

    public void wrongMove()
    {
        correctPipes -= 1;
    }
}
