using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningController : MonoBehaviour
{
    public Material flashMaterial; // Assign the material using your shader here.
    public float flashIntensity = 1.0f;
    public float flashDuration = 0.1f;

    private void Start()
    {
        StartCoroutine(TriggerLightning());
    }

    IEnumerator TriggerLightning()
    {
        while (true)
        {
            flashMaterial.SetFloat("_FlashIntensity", flashIntensity);
            yield return new WaitForSeconds(flashDuration);
            flashMaterial.SetFloat("_FlashIntensity", 0.0f); // Reset the flash intensity.
            yield return new WaitForSeconds(Random.Range(2, 3));
        }
    }
}

