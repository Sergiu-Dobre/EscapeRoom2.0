using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayMyAnimationTreasure : MonoBehaviour
{
    [SerializeField] 
    private Animator myAnimationControler;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
        
          myAnimationControler.SetBool("playSpin2", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
          
          myAnimationControler.SetBool("playSpin2", false);
        }
    }
  
 
}
