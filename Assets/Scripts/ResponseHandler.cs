using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;


public class ResponseHandler : MonoBehaviour
{

    [SerializeField] private RectTransform responseBox;
    [SerializeField] private RectTransform responseButtonTemplate;
    [SerializeField] private RectTransform responseContainer;

    public DialogueUI dialogueUI;

    public void ShowResponses(Response[] responses)
    {

        float responseBoxHeight = 0;

        foreach (Response response in responses)
        {

            GameObject responseButton = Instantiate(responseButtonTemplate.gameObject, responseContainer);

            responseButton.gameObject.SetActive(true);
            responseButton.GetComponent<TMP_Text>().text = response.ResponseText;
            responseButton.GetComponent<Button>().onClick.AddListener(call: () => OnPickedResponse(response));

            responseBoxHeight += responseButtonTemplate.sizeDelta.y;

        }

        responseBox.sizeDelta = new Vector2(responseBox.sizeDelta.x, y: responseBoxHeight);
        responseBox.gameObject.SetActive(true);

    }

    private void OnPickedResponse(Response response)
    {

        responseBox.gameObject.SetActive(false);

        Button[] tempResponseButtons = responseContainer.GetComponentsInChildren<Button>();
        foreach (Button button in tempResponseButtons)
        {

            Destroy(button);

        }


        dialogueUI.ShowDialogue(response.DialogueObject);

    }

}
