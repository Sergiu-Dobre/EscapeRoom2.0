using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public NPC npc;
    public Collider dialogueCollider;
    public GameObject dialogueUI;
    public TMP_Text npcDialogueBox;

    private bool isTalking;
    private int curDialogueIndex;

    private void Start()
    {
        dialogueUI.SetActive(false);
        Cursor.visible = true;
    }

    private void Update()
    {
        if (!isTalking && Input.GetKeyDown(KeyCode.E))
        {
            if (dialogueCollider.bounds.Contains(transform.position))
            {
                StartConversation();
            }
            else
            {
                Debug.Log("Player is not colliding with the dialogue collider.");
            }
        }
        else if (isTalking && Input.GetMouseButtonDown(0)) // Left mouse button
        {
            ProcessNextDialogue();
        }
    }

    void StartConversation()
    {
        isTalking = true;
        curDialogueIndex = 0;
        dialogueUI.SetActive(true);
        npcDialogueBox.text = npc.dialogue[curDialogueIndex];
        Debug.Log("Conversation started.");
    }

    void ProcessNextDialogue()
    {
        curDialogueIndex++;

        if (curDialogueIndex < npc.dialogue.Length)
        {
            npcDialogueBox.text = npc.dialogue[curDialogueIndex];
        }
        else
        {
            EndConversation();
        }
    }

    void EndConversation()
    {
        isTalking = false;
        dialogueUI.SetActive(false);
        Debug.Log("Conversation ended.");
    }
}
