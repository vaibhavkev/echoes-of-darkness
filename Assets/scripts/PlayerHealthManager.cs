using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public float PlayerHealth;
    [SerializeField] private HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth = 100f;
        healthBar.setmaxhealth(100);
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.sethealth(PlayerHealth);
        Debug.Log(PlayerHealth);
    }
}
