using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OpenCipher : MonoBehaviour
{
    private Animator anie;

    private bool IsAtCipher = true;

    
    [SerializeField]
    private TextMeshProUGUI CodeText;
    string codeTextValue = "";
    public string safeCode;
    public GameObject CodePanel;
    

    void Start()
    {
        anie = GetComponent<Animator>();
        
        CodePanel.SetActive(false);
    }

    void Update()
    {
        CodeText.text = codeTextValue;

        if(codeTextValue == safeCode)
        {
            anie.SetTrigger("PlayAnimation");
            CodePanel.SetActive(false);
        }

        if(codeTextValue.Length >= 6)
        {
            codeTextValue = "";
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        { 
            IsAtCipher = true;
            CodePanel.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {   
        if(other.tag == "Player")
        {
          IsAtCipher = false;
           CodePanel.SetActive(false);
        }
    }
    
    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}   

