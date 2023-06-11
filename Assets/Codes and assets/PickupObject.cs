using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour

{
    public float pickupDistance = 3f; 
    public Transform holdPosition; 
    public LayerMask pickupLayerMask; 

    private GameObject heldObject;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (heldObject == null)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.forward, out hit, pickupDistance, pickupLayerMask))
                {
                    heldObject = hit.collider.gameObject;
                    heldObject.GetComponent<Rigidbody>().isKinematic = true;
                    heldObject.transform.position = holdPosition.position;
                    heldObject.transform.parent = holdPosition;
                }
            }
            else
            {
                
                heldObject.GetComponent<Rigidbody>().isKinematic = false;
                heldObject.transform.parent = null;
                heldObject = null;
            }
        }

        if (heldObject != null)
        {
            heldObject.transform.position = holdPosition.position;
        }
    }
}
