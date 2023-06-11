using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYButtonIntro : MonoBehaviour
{
     public void OnPLAYButtonIntroClicked()
     {
        SceneManager.LoadScene("Inside of the house");
     }
}
