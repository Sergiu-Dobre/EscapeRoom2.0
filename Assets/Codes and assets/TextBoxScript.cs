using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxScript : MonoBehaviour

{
    public GameObject currentObject;

    private Text textBox;

    void Start()
    {
        textBox = GetComponent<Text>();
        textBox.enabled = false;
    }

    public void ShowText(string message)
    {
        textBox.text = message;
        textBox.enabled = true;
    }

    void Update()
    {
        if (currentObject == null)
        {
            textBox.enabled = false;
            return;
        }

        string message = "Object: " + currentObject.name;
        ShowText(message);
    }
}
