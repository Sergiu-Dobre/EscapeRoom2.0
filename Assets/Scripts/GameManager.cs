using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PipesHolder;
    public GameObject[] Pipes;
    public GameObject door;
    public GameObject puzzle;
    public GameObject fin;

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

        Debug.Log("correct move");

        if(correctPipes == totalPipes)
        {
            //door.SetActive(false);
            door.GetComponent<Animator>().enabled = true;
            puzzle.SetActive(false);
            fin.SetActive(true);
        }
    }

    public void wrongMove()
    {
        correctPipes -= 1;
    }
}
