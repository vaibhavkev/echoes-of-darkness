using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsFlicker : MonoBehaviour
{
    public Light lightOB;

    public AudioSource lightSound;

    public float minTime;
    public float maxTime;
    public float timer;
    [SerializeField] private float cooldown;


    void Start()
    {
        timer = Random.Range(minTime, maxTime);
        cooldown = 2f;
    }




    void Update()
    {
        LightsFlickering();
    }

    void LightsFlickering()
    {
        if (timer > 0)
            cooldown -= Time.deltaTime;
            timer -= Time.deltaTime;
        if (cooldown < 0)
        {
            timer -= Time.deltaTime;
            lightOB.enabled = false;
            cooldown = 0.7f;
        }

        if (timer <= 0)
        {
            lightOB.enabled = true;
            timer = Random.Range(minTime, maxTime);
            lightSound.Play();
        }



    }
}
