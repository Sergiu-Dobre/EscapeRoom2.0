using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LableAppear : MonoBehaviour
{
    [SerializeField]
    private GameObject uiObject;

    void Start ()
    {
        uiObject.SetActive(false);
    }

   void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Player")
       {  
        uiObject.SetActive(true);
       }
    }

    void OnTriggerExit (Collider other)
    {
        uiObject.SetActive(false);
       
    }
}

  