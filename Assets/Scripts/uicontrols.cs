using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uicontrols : MonoBehaviour
{
    public GameObject lmb;

    
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void OnTriggerEnter()
    {
        lmb.SetActive(true);
    }

    private void OnTriggerExit()
    {
        lmb.SetActive(false);
    }
}
