using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTrigger : MonoBehaviour
{
  //  public ParticleSystem sxplosion;
    public CameraShake cameraShake;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
    //        explosion.Play();
            StartCoroutine(cameraShake.Shake(.15f, .4f));
        }
    }
}
