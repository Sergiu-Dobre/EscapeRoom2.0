using UnityEngine;
using System.Collections;

public class DialPuzzleController : MonoBehaviour
{

    // Array of the four dials in the puzzle
    public DialController[] dials;

    

    // Array of the correct order of the dials
    public int[] correctOrder;

    public GameObject CombinationLock;
    public GameObject Door;

    //public GameObject otherGameObject;

    public GameObject lockcol;
    public GameObject box;
    public GameObject enablepick;
    public GameObject lockobj;
    //public GameObject camon;

    public Camera alternativeCamera;
    public Camera mainCamera;

    public GameObject button;
    public GameObject safedoor;

    float timer;

    // Update is called once per frame
    void Update()
    {
      
        // Check if the dials are in the correct order
        bool isCorrectOrder = true;
        for (int i = 0; i < dials.Length; i++)
        {
            if (dials[i].CurrentValue != correctOrder[i])
            {
                isCorrectOrder = false;
                break;
            }
        }

        // If the dials are in the correct order, display a message
        if (isCorrectOrder)
        {
            Debug.Log("It's correct!");
            CombinationLock.GetComponent<Animator>().enabled = true;
            Door.GetComponent<Animator>().enabled = true;
            //lockobj.SetActive(false);

            box.SetActive(false);
            enablepick.SetActive(true);

            //switch to main camera
            //camon.SetActive(true);
            lockobj.SetActive(false);
            lockcol.SetActive(false);

            button.SetActive(true);
            safedoor.GetComponent<Animator>().enabled = true;

            timer += Time.deltaTime;
            if (timer >= 2)
            {
                MyFunction();
            }

            
            //otherGameObject.GetComponent<BoxCollider>();
            //Destroy(locktrigger.GetComponent<BoxCollider>());
        }
    }

    void MyFunction()
            {
                alternativeCamera.enabled = false;
                mainCamera.enabled = true;
                Debug.Log("it woorks");
            }
}

