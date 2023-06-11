using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Didit_For_Puzzle : MonoBehaviour
{
    public float snapDistanceThreshold = 0.1f;
    public GameObject snapObject; 
    public GameObject imageObject; 
    private bool isSnapped = false;

    void Start()
    {
        imageObject.SetActive(false); 
    }

    void Update()
    {

        if (!isSnapped && snapObject != null)
        {
            
            if (Vector3.Distance(transform.position, snapObject.transform.position) < snapDistanceThreshold)
            {
            
                imageObject.SetActive(true); 
                isSnapped = true;
            }
        }
        else if (isSnapped && snapObject == null)
        {
            imageObject.SetActive(false); 
            isSnapped = false;
        }
    }
}