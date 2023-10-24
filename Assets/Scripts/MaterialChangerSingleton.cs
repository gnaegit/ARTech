using UnityEngine;

public class MaterialChangerSingleton : GenericSingleton<MaterialChangerSingleton>
{
    public void ChangeMaterial(GameObject gameObject, Material newMaterial)
    {
        Renderer[] childrenRenderer = gameObject.GetComponentsInChildren<Renderer>();
        gameObject.GetComponent<Renderer>().material = newMaterial;
        foreach (Renderer rend in childrenRenderer)
        {
            rend.material = newMaterial;
        }
    }
}
