using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightning : MonoBehaviour
{
    public float lightningDuration = 0.1f;
    public float lightningDelay = 2f;
    public float lightningIntensity = 1f;
    public float lightningRange = 10f;
    public GameObject lightningTarget;

    private float lightningTimer = 0f;

    void Update()
    {
        if (lightningTimer <= 0)
        {
            Vector3 targetPosition = lightningTarget.transform.position;
            Vector3 startPosition = new Vector3(targetPosition.x + Random.Range(-lightningRange, lightningRange), targetPosition.y + Random.Range(-lightningRange, lightningRange), targetPosition.z);
            GetComponent<LineRenderer>().SetPosition(0, startPosition);
            GetComponent<LineRenderer>().SetPosition(1, targetPosition);
            GetComponent<LineRenderer>().enabled = true;
            Invoke("DisableLightning", lightningDuration);
            lightningTimer = lightningDelay;
        }
        else
        {
            lightningTimer -= Time.deltaTime;
        }
    }

    void DisableLightning()
    {
        GetComponent<LineRenderer>().enabled = false;
    }
}
