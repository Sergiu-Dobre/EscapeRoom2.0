using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class DialogueUI : MonoBehaviour
{

    [SerializeField] private TMP_Text textLabel;
   
    [SerializeField] GameObject dialogueBox;

    public bool IsOpen { get; private set; }

    private ResponseHandler responseHandler;
    private TypeWriterEffect typeWriterEffect;

    private void Start()
    {

        responseHandler = GetComponent<ResponseHandler>();

        typeWriterEffect = GetComponent<TypeWriterEffect>();

        CloseDialogueBox();

    }

    public void ShowDialogue(DialogueObject dialogueObject)
    {


        IsOpen = true;
        dialogueBox.SetActive(true);

        StartCoroutine(routine: StepThroughDialogue(dialogueObject));

    }

    private IEnumerator StepThroughDialogue(DialogueObject dialogueObject)
    {
        for (int i = 0; i < dialogueObject.Dialogue.Length; i++)
        {

            string dialogue = dialogueObject.Dialogue[i];
            yield return typeWriterEffect.Run(dialogue, textLabel);

            if (i == dialogueObject.Dialogue.Length - 1 && dialogueObject.HasResponses) break;


            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Mouse0));
        }

        if (dialogueObject.HasResponses)
        {

            responseHandler.ShowResponses(dialogueObject.Responses);

        }

        CloseDialogueBox();
    }

    private void CloseDialogueBox()
    {

        IsOpen = false;
        dialogueBox.SetActive(false);
        textLabel.text = string.Empty;

    }

}
