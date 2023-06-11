using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToSlot : MonoBehaviour
{
    public float snapDistance = 0.1f;

    private Collider[] slots;
    private Collider currentSlot;

    void Start()
    {
       
        slots = transform.parent.GetComponentsInChildren<Collider>();
    }

    void Update()
    {
        
        Collider closestSlot = null;
        float closestDistance = float.MaxValue;
        foreach (Collider slot in slots)
        {
            float distance = Vector3.Distance(transform.position, slot.transform.position);
            if (distance < snapDistance && distance < closestDistance)
            {
                closestSlot = slot;
                closestDistance = distance;
            }
        }

        // Snap to the closest slot
        if (closestSlot != null && closestSlot != currentSlot)
        {
            transform.position = closestSlot.transform.position;
            transform.rotation = closestSlot.transform.rotation;
            currentSlot = closestSlot;
        }
    }
}