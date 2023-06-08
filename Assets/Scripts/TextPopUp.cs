using UnityEngine;
using TMPro;

public class TextPopUp : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI popupText;
    private bool isColliding = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = true;
            ShowPopupText();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isColliding = false;
            HidePopupText();
        }
    }

    private void Update()
    {
        if (isColliding)
        {
            // Perform any desired text updates while the collision is happening
            // For example, you can update the text content dynamically here
        }
    }

    private void ShowPopupText()
    {
        popupText.gameObject.SetActive(true);
    }

    private void HidePopupText()
    {
        popupText.gameObject.SetActive(false);
    }

}
