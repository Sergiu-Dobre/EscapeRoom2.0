using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OpenDoor : MonoBehaviour
{
    private bool openDoor;
    //temporary fix
    [SerializeField] GameObject door;
    public GameObject Door;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            openDoor = true;
        }
        else
        {
            openDoor = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (openDoor)
        {
            if (other.tag == "Player")
            {

                //TODO: play animation
                
                door.SetActive(false);
                Door.GetComponent<Animator>().enabled = true;


            }
        }
    }
}
