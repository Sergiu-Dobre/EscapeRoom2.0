using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{
    public bool IsPlaced { get; private set; }

    public Transform correctPosition;

    private Collider col;

    private void Start()
    {
        col = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == correctPosition)
        {
            col.enabled = false;
            
            transform.position = correctPosition.position;
            transform.rotation = correctPosition.rotation;

            IsPlaced = true;

            CheckIfAllPiecesPlaced();
        }
    }

    private void CheckIfAllPiecesPlaced()
    {
        PuzzlePiece[] puzzlePieces = FindObjectsOfType<PuzzlePiece>();

        foreach (PuzzlePiece piece in puzzlePieces)
        {
            if (!piece.IsPlaced)
            {
                return;
            }
        }

        
    }
}