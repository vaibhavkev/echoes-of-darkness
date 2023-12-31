using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyTakeDamage : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    // Reference to the player GameObject
    public GameObject player;
    // Range within which the enemy can be attacked
    public float attackRange = 2f;
    // Reference to the player's animator
    private Animator playerAnimator;

    void Start()
    {
        currentHealth = maxHealth;
        playerAnimator = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerAttacking() && IsPlayerInRange())
        {
            TakeDamage(0f); // Adjust the damage value as needed
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullets")
        {
            TakeDamage(10f);
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        // Ensure health doesn't go below zero.
        currentHealth = Mathf.Max(currentHealth, 0);

        // Check for death
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    private bool IsPlayerInRange()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        return distanceToPlayer <= attackRange;
    }

    private bool IsPlayerAttacking()
    {
        Debug.Log(playerAnimator.GetBool("attack"));
        // Assuming you have a trigger parameter "IsAttacking" in the player's animator
        return playerAnimator.GetBool("attack");
    }
}
