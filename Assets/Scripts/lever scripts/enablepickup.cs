using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enablepickup : MonoBehaviour
{
    public GameObject enablepick;

    private void OnTriggerStay()
    {
        enablepick.SetActive(true);
    }

    private void OnTriggerExit()
    {
        enablepick.SetActive(false);
    }
}
