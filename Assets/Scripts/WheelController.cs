using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && IsPlayerCloseToObject())
        {
            animator.SetTrigger("TurnWheel");
        }
    }

    bool IsPlayerCloseToObject()
    {
        float distanceThreshold = 2f; // Define the distance threshold for proximity
        GameObject player = GameObject.FindGameObjectWithTag("Player"); // Assuming the player is tagged as "Player"
        float distance = Vector3.Distance(player.transform.position, transform.position); // Calculate the distance between player and object

        return distance <= distanceThreshold; // Return true if the player is within the distance threshold
    }

}



