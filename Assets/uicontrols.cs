using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uicontrols : MonoBehaviour
{
    public GameObject lmb;

    private void OnTriggerEnter()
    {
        lmb.SetActive(true);
    }

    private void OnTriggerExit()
    {
        lmb.SetActive(false);
    }
}
