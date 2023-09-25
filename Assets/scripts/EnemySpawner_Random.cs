using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform player;      
    public float spawnRadius = 20f;
    private float timer = 0;
    private float idealtime = 20;

    void Update()
    {
        if (timer > idealtime)
        {
            timer = 0;
            SpawnEnemy();
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemyspawn")
        {
            SpawnEnemy();
        }
    }


    public void SpawnEnemy()
    {
        Vector3 spawnPosition = GetRandomPositionAroundPlayer();
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

    private Vector3 GetRandomPositionAroundPlayer()
    {
        // Get a random angle between 0 and 2*PI
        float angle = Random.value * Mathf.PI * 2;

        // Convert angle to a direction
        Vector3 direction = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle));

        // Get a random distance from 0 to spawnRadius
        float distance = 10 + Random.value * spawnRadius;

        // Calculate the spawn position
        Vector3 spawnPosition = player.position + direction * distance;

        return spawnPosition;
    }
}

