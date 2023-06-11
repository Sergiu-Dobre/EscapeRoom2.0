using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxClick : MonoBehaviour
{
    public Animator animator;
    private bool isPlayerInsideTriggerZone = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInsideTriggerZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInsideTriggerZone = false;
        }
    }

    void Update()
    {
        if (isPlayerInsideTriggerZone && Input.GetKeyDown(KeyCode.R))
        {
            // Check if the animation is already playing
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("bob"))
            {
                // Start the animation
                animator.Play("bob");
            }
        }
    }
}
