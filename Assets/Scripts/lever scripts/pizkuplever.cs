using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizkuplever : MonoBehaviour
{
    public GameObject leverpick;
    public GameObject iflever;

    private void OnTriggerStay()
    {
        if (Input.GetKeyDown(KeyCode.E))
        leverpick.SetActive(false);
        iflever.SetActive(true);
    }

    
}
