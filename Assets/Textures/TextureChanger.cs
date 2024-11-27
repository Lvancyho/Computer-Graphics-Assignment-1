using UnityEngine;

public class TextureChanger : MonoBehaviour
{
    public Texture2D texture1 = null;
    public Texture2D texture2 = null;

    public bool useTexture2 = false;

    bool oldSetting = false;
    Renderer[] renderers = null;


    void Start()
    {
        renderers = GetComponentsInChildren<Renderer>();
        UpdateAllMaterials();
    }

    public void UpdateAllMaterials()
    {
        Texture textureToSet = texture1;
        if (useTexture2)
            textureToSet = texture2;
        for (int i = 0; i < renderers.Length; i++)
            renderers[i].material.mainTexture = textureToSet;
        oldSetting = useTexture2;
    }

    void Update()
    {
        if (useTexture2 != oldSetting)
            UpdateAllMaterials();
    }

    public void ChangeThing()
    {
        if (!useTexture2) { useTexture2 = true; }
        else { useTexture2 = false; }
    }
}