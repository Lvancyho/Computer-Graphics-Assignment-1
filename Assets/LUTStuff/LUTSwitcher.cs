using UnityEngine;

public class LUTSwitcher : MonoBehaviour
{
    public MonoBehaviour CustomLUT; //refers to custom LUT script
    public MonoBehaviour WarmLUT; //warm script
    public MonoBehaviour CoolLUT; //cool script

    private MonoBehaviour currentScript; //current active LUT script

    public void SetActiveScript(MonoBehaviour scriptToToggle)
    {
        // If the selected script is already active, disable it and clear currentScript
        if (currentScript == scriptToToggle)
        {
            scriptToToggle.enabled = false;
            currentScript = null;
        }
        else
        {
            // Disable the currently active script if it exists
            if (currentScript != null)
            {
                currentScript.enabled = false;
            }

            // Enable the selected script
            if (scriptToToggle != null)
            {
                scriptToToggle.enabled = true;
            }

            currentScript = scriptToToggle;
        }
    }

    // Call these from the UI buttons
    public void ToggleCustomLUT() => SetActiveScript(CustomLUT);
    public void ToggleWarmLUT() => SetActiveScript(WarmLUT);
    public void ToggleCoolLUT() => SetActiveScript(CoolLUT);
}
