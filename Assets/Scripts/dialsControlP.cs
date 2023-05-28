using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialsControlP : MonoBehaviour
{
    float[] rotations = { 0, 120, -60 };

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

        if (PossibleRots > 1)
        {
            foreach (float rotation in correctRotation)
            {
                if (Mathf.Abs(transform.eulerAngles.y - rotation) < 0.01f)
                {
                    isPlaced = true;
                    gameManager.correctMove();
                    break;
                }
            }
        }
        else
        {
            if (Mathf.Abs(transform.eulerAngles.y - correctRotation[0]) < 0.01f)
            {
                isPlaced = true;
                gameManager.correctMove();
            }
        }
    }

    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 120, 0));
        //Debug.Log("Pressed button");

        if (PossibleRots > 1)
        {
            foreach (float rotation in correctRotation)
            {
                if (Mathf.Abs(transform.eulerAngles.y - rotation) < 0.01f && !isPlaced)
                {
                    isPlaced = true;
                    gameManager.correctMove();
                    break;
                }
                else if (isPlaced)
                {
                    isPlaced = false;
                    gameManager.wrongMove();
                    break;
                }
            }
        }
        else
        {
            if (Mathf.Abs(transform.eulerAngles.y - correctRotation[0]) < 0.01f && !isPlaced)
            {
                isPlaced = true;
                gameManager.correctMove();
            }
            else if (isPlaced)
            {
                isPlaced = false;
                gameManager.wrongMove();
            }
        }
    }
}
