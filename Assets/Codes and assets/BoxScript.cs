using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class BoxScript : MonoBehaviour

{
    public GameObject objectForPicking; 
    public GameObject numberBox; 
    public TMP_Text numberText; 

    private bool objectInBox = false; 

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject == objectForPicking)
        {
           
            other.transform.SetParent(numberBox.transform);
            other.transform.localPosition = Vector3.zero;

            objectInBox = true;

           
            numberText.enabled = true;
            numberText.text = "2333W";
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
       
        if (other.gameObject == objectForPicking)
        {
            
            other.transform.SetParent(null);
            
            objectInBox = false;

            numberText.enabled = false;
        }
    }

    private void Update()
    {
 
        if (objectInBox)
        {
            
            if (objectForPicking.transform.parent != numberBox.transform)
            {
                
                objectInBox = false;
                numberText.enabled = false;
            }
        }
    }
}
