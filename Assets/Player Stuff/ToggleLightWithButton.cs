using UnityEngine;

public class ToggleLightWithButton : MonoBehaviour
{
    public Light[] directionalLight;

    public void ToggleLight()
    {

        foreach (Light light in directionalLight)
        {
            if (light != null)
            {

                light.enabled = !light.enabled;
            }
        }
    }
}
