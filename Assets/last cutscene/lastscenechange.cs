using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lastscenechange : MonoBehaviour
{
    public string lastscene;
    public string menu; // Name of the scene you want to switch to
    public float delayTime = 350f; // Delay time in seconds

    private float timer;

    private void Start()
    {
        timer = 0f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delayTime)
        {
            ChangeScene();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(menu);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(lastscene);
    }
}
