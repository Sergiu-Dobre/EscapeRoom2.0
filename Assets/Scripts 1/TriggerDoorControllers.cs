using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorControllers : MonoBehaviour
{

    private Animator myDoor = null;

    private bool openTrigger = false; 
    private bool closeTrigger = false;

    private void OnTriggerEnter (Collider other)
    {
       if (other.CompareTag("PlayerCapsule"))
        {
            if (openTrigger)
            {
              
               myDoor.Play("DoorOpen", 0, 0.0f);
               gameObject.SetActive(false);
            }
            
            else if (closeTrigger)
            {
              myDoor.Play("DoorClose", 0, 0.0f);
              gameObject.SetActive(false);

            }
        }
    }
}

