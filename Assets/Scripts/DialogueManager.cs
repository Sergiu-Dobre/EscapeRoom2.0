using UnityEngine;

using TMPro;



public class DialogueManager : MonoBehaviour

{

    public NPC npc;

    public GameObject player;

    public GameObject dialogueUI;

    public TMP_Text npcDialogueBox;

    public TMP_Text playerResponse;



    private bool isTalking;

    private float distance;

    private int curResponseTracker;



    private void Start()

    {

        dialogueUI.SetActive(false);

        Cursor.visible = true;

    }



    private void OnMouseOver()

    {

        distance = Vector3.Distance(player.transform.position, transform.position);



        if (distance <= 2.5f)

        {

            // Scroll between answers using mouse wheel 

            float scroll = Input.GetAxis("Mouse ScrollWheel");

            if (scroll > 0f)

            {

                curResponseTracker--;

                if (curResponseTracker < 0)

                {

                    curResponseTracker = 0;

                }

            }

            else if (scroll < 0f)

            {

                curResponseTracker++;

                if (curResponseTracker >= npc.playerDialogue.Length)

                {

                    curResponseTracker = npc.playerDialogue.Length - 1;

                }

            }



            // Dialogue pops up 

            if (Input.GetKeyDown(KeyCode.E) && !isTalking)

            {

                StartConversation();

            }

            else if (Input.GetKeyDown(KeyCode.E) && isTalking)

            {

                EndConversation();

            }



            if (curResponseTracker < npc.playerDialogue.Length)

            {

                playerResponse.text = npc.playerDialogue[curResponseTracker];

                if (Input.GetKeyDown(KeyCode.Return))

                {

                    ProcessPlayerResponse();

                }

                else if (Input.GetMouseButtonDown(2)) // Middle mouse button 

                {

                    ProcessPlayerResponse();

                }

            }

        }

    }



    void StartConversation()

    {

        isTalking = true;

        curResponseTracker = 0;

        dialogueUI.SetActive(true);

        npcDialogueBox.text = npc.dialogue[0];

    }



    void EndConversation()

    {

        isTalking = false;

        dialogueUI.SetActive(false);

    }





    void ProcessPlayerResponse()

    {

        if (curResponseTracker < npc.dialogue.Length - 1)

        {

            npcDialogueBox.text = npc.dialogue[curResponseTracker + 1];

        }

        else

        {

            EndConversation();

        }



        curResponseTracker++; // Move to the next NPC response 

        playerResponse.text = ""; // Clear the player response text 

    }





}

