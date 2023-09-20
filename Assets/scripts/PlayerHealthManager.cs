using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public float PlayerHealth;
    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(PlayerHealth);
    }
}
