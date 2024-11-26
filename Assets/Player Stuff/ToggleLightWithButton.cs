using UnityEngine;

public class ToggleLightWithButton : MonoBehaviour
{
    public Light directionalLight;

    public void ToggleLight()
    {
        if (directionalLight != null)
        {
            directionalLight.enabled = !directionalLight.enabled;
        }
        else
        {
        }
    }
}
