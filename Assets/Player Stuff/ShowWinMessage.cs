using UnityEngine;
using UnityEngine.UI;

public class ShowWinMessage : MonoBehaviour
{
    public MonoBehaviour displayText; //Assign the UI text you want to be tinkered with

    void Start()
    {
        if (displayText != null)
            displayText.gameObject.SetActive(false); // Hides the text at the start
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) || Input.GetKeyDown(KeyCode.Y))
        {
            if (displayText != null)
                displayText.gameObject.SetActive(true); // Show the text when either key is pressed
        }

        if (Input.GetKeyUp(KeyCode.T) || Input.GetKeyUp(KeyCode.Y))
        {
            if (displayText != null)
                displayText.gameObject.SetActive(false); // Hide the text when either key is released
        }
    }
}
