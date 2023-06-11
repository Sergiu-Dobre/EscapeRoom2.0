using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    public GameObject key;
    public Animator animator;

    private bool isKeyDestroyed = false;

    private void Start()
    {
        // Disable the animator component by default
        animator.enabled = false;
    }

    private void Update()
    {
        // Check if the key object has been destroyed
        if (key == null && !isKeyDestroyed)
        {
            isKeyDestroyed = true;

            // Enable the animator component to play the opening animation
            animator.enabled = true;
        }
    }
}
