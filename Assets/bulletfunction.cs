using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletfunction : MonoBehaviour

{
    public float destroyDistance = 0.01f;
    void Update()
    {
        CheckForEnemyDestroy();
    }
    void CheckForEnemyDestroy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("zombie");

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);

            if (distance < destroyDistance)
            {
                //Destroy(gameObject);
            }
        }
    }
}
