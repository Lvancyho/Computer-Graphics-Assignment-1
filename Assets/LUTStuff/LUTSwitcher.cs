using System.Collections.Generic;
using UnityEngine;

public class LUTSwitcher : MonoBehaviour
{
    public List<Material> LUTs = new List<Material>(); // Created a list to hold the LUT materials
    public ScreenCameraShader cameraShader; // Grabs the camera shader to display the LUT

    private void Start()
    {
        cameraShader = Camera.main.GetComponent<ScreenCameraShader>(); // Get the camera shader script on game start
    }

    // Function to change the LUT material
    void SwitchActiveLUT(Material currentLUT)
    {
        cameraShader.m_renderMaterial = currentLUT;
    }

    // Call these from the UI buttons
    public void ToggleCustomLUT() => SwitchActiveLUT(LUTs[0]);
    public void ToggleWarmLUT() => SwitchActiveLUT(LUTs[1]);
    public void ToggleCoolLUT() => SwitchActiveLUT(LUTs[2]);
    public void ToggleNoLUT() => SwitchActiveLUT(LUTs[3]);
}
