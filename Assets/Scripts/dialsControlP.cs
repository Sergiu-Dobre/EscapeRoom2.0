using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialsControlP : MonoBehaviour
{
    float[] rotations = { 0, 120, -60, };

    public float[] correctRotation;
    [SerializeField]
    bool isPlaced = false;

    int PossibleRots = 1;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("puzzlemanager").GetComponent<GameManager>();
    }

    private void Start()
    {
        PossibleRots = correctRotation.Length;
        //int rand = Random.Range(0, rotations.Length);
        //transform.eulerAngles = new Vector3(0, 0, rotations[rand]);

        if(PossibleRots > 1)
        {
        if (transform.eulerAngles.y == correctRotation[0] || transform.eulerAngles.y == correctRotation[1])
        {
            isPlaced = true;
            gameManager.correctMove();
        }
        else
        {
            if (transform.eulerAngles.y == correctRotation[0])
        {
            isPlaced = true;
            gameManager.correctMove();
        }
        }
        }
    }

    private void OnMouseDown()
    {
        transform.Rotate (new Vector3(0, 120, 0));
        Debug.Log("Pressed button");

        if(PossibleRots > 1)
        {
            if(transform.eulerAngles.y == correctRotation[0] || transform.eulerAngles.y == correctRotation[1] && isPlaced == false)
            {
                isPlaced = true;
                gameManager.correctMove();
            }

            else if(isPlaced == true)
            {
                isPlaced = false;
                gameManager.wrongMove();
            }
        }

        else
        {
            if(transform.eulerAngles.y == correctRotation[0] && isPlaced == false)
            {
                isPlaced = true;
                gameManager.correctMove();
            }
            else if(isPlaced == true)
            {
                isPlaced = false;
                gameManager.wrongMove();
            }
        }
    }
}
