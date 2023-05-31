using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placelever : MonoBehaviour
{
    public GameObject leverp;
    public GameObject placedlever;
    public GameObject doorop;

    private bool playerInRange = false;

    
    void Update()
    {
        if (leverp.activeSelf)
        {
            if (playerInRange && Input.GetKeyDown(KeyCode.E))
            {
                placedlever.SetActive(true);
                //doorop.SetActive(false);
                StartCoroutine(waiti());
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Replace "Player" with the appropriate tag of the player object
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Replace "Player" with the appropriate tag of the player object
        {
            playerInRange = false;
        }
    }

    IEnumerator waiti()
    {
        yield return new WaitForSeconds(2);
        doorop.SetActive(false);
        Debug.Log("waits");
    }
}
