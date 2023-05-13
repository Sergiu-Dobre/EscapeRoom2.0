using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActivator : MonoBehaviour, IInteractable
{
    [SerializeField] private DialogueObject dialogueObject;
    [SerializeField] private DialogueUI dialogueUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out BasicMovement player))
        {
            player.Interactable = this;
            dialogueUI = player.GetComponent<DialogueUI>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out BasicMovement player))
        {
            if (player.Interactable is DialogueActivator dialogueActivator && dialogueActivator == this)
            {
                player.Interactable = null;
                dialogueUI = null;
            }
        }
    }

    public void Interact(BasicMovement player)
    {
        if (dialogueUI != null)
        {
            dialogueUI.ShowDialogue(dialogueObject);
        }
    }
}
