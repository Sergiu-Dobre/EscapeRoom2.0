using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public CharacterController controlls;
    // callin character controller

    public float speed = 12f;
    //define speed variable
    Vector3 velocity;
    // degfine velocity vecor 3

    // Update is called once per frame
    void Update()
    {
       
        // x,z axes for movment speed
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        //this way we move where our player "look"
       

        controlls.Move(move * speed * Time.deltaTime);
        // movement will not be affected by frames
        controlls.Move(velocity * Time.deltaTime);
    }
}
