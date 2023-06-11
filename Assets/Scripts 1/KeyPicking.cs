using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPicking : MonoBehaviour
{
    public GameObject KeyCollect;

    void Start() {

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(KeyCollect);
        }
    }

}   
