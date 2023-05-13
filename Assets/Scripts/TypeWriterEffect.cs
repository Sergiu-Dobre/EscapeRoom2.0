using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;


public class TypeWriterEffect : MonoBehaviour
{

    [SerializeField] private float typingSpeed = 50f;

    public Coroutine Run(string textToType, TMP_Text textLabel)
    {

        return StartCoroutine(routine: TypeText(textToType, textLabel));

    }

    internal void Run(string textToType)
    {
        throw new NotImplementedException();
    }

    private IEnumerator TypeText(string textToType, TMP_Text textLabel)
    {

        textLabel.text = string.Empty;

        float t = 0;
        int charIndex = 0;

        while (charIndex < textToType.Length)
        {

            t += Time.deltaTime * typingSpeed;
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(value: charIndex, min:0, max: textToType.Length);

            textLabel.text = textToType.Substring(startIndex: 0, length: charIndex);

            yield return null;

        }

        textLabel.text = textToType;
    
    }

}
