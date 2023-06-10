using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor;


public class RenderSettings : MonoBehaviour
{
    [SerializeField] private bool allowInteraction=false;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            allowInteraction = true;
            RenderSettings.Destroy(this);
        }
        else
        {
            allowInteraction = false;
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (allowInteraction)
        {
            if (other.tag == "Player")
            {
               RenderSettings.Destroy(this);
               // RenderSettings.fog = false;
               //was about to change the fog but this gives me an error and could not troubleshoot it
                Debug.Log("Light settings change");

             
            }

        }

    }
}
