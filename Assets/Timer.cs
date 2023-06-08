using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private int startingMinutes = 0;
    [SerializeField] private int startingSeconds = 10;

    [SerializeField] private TMP_Text countdownText;

    private float currentTime;

    private void Start()
    {
        currentTime = startingMinutes * 60 + startingSeconds;
    }

    private void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;

            // Calculate minutes and seconds
            int minutes = Mathf.FloorToInt(currentTime / 60);
            int seconds = Mathf.FloorToInt(currentTime % 60);

            // Update countdown text
            countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            currentTime = 0f;
            countdownText.text = currentTime.ToString("0");
            // Perform actions when the timer reaches 0
        }
    }
}
