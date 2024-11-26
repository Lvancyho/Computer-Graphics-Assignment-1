using UnityEngine;

public class ToggleScriptOnCamera : MonoBehaviour
{
    public Camera targetCamera;
    public MonoBehaviour scriptToToggle;

    // Method to toggle the script (can be called by a UI Button)
    public void ToggleScript()
    {
        if (scriptToToggle != null)
        {
            scriptToToggle.enabled = !scriptToToggle.enabled;
        }
        else
        {

        }
    }
}
