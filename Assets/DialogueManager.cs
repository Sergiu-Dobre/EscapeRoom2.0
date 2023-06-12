
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public NPC npc;
    public Collider dialogueCollider;
    public GameObject dialogueUI;
    public TMP_Text npcDialogueBox;
    public float maxDistance = 3f; // Maximum distance for the player to interact with the NPC

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
            if (dialogueCollider.bounds.Contains(transform.position) && Vector3.Distance(transform.position, dialogueCollider.transform.position) <= maxDistance)
            {
                StartConversation();
            }
            else
            {
                Debug.Log("Player is not in range of the dialogue collider.");
            }
        }

        // Check if the UI is active before processing next dialogue
        if (isTalking && dialogueUI.activeSelf && Input.GetMouseButtonDown(0)) // Left mouse button
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
