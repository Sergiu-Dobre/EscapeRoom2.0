using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uioff : MonoBehaviour
{
    public GameObject lmb;

    private void OnTriggerEnter()
    {
        lmb.SetActive(false);
    }

    private void OnTriggerExit()
    {
        lmb.SetActive(false);
    }
}
