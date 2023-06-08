using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public float mouseDPI = 100f;
    public Transform pBody;
    float rotationX = 100f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //we are hiding and cursor (there is a knob on the UI)
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        //rotation on X or Y(mouse) won't be afected by frames 
        float mouseY = Input.GetAxis("Mouse Y");

        rotationX -= mouseY;
        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
        rotationX = Mathf.Clamp(rotationX, -90, 90);
        //clamping the rotation

        pBody.Rotate(Vector3.up * mouseX * Time.deltaTime * mouseDPI);

    }
}
