using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class safebutton : MonoBehaviour
{
    public string nextscene;
    public GameObject buttonpress;

    void OnTriggerStay()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            buttonpress.GetComponent<Animator>().enabled = true;
            SceneManager.LoadScene(nextscene);
        }
    }
}
