using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Box_Activate : MonoBehaviour
{
    private Animator animator;
    private bool isPlayerInTriggerZone = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInTriggerZone = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInTriggerZone = false;
        }
    }

    void Update()
    {
        if (isPlayerInTriggerZone && Input.GetKeyDown(KeyCode.R))
        {
            animator.enabled = true;
            animator.SetTrigger("PlayAnimation");
        }
    }
}
