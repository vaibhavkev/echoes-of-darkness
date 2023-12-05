using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletspawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public Vector3 velocity;
    public float destroyDistance = 0.01f;
    public Transform object1;
    public Transform object2;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnCube();
        }
    }
    void SpawnCube()
    {
        Vector3 velocity = object1.position - object2.position;
        GameObject cube = Instantiate(cubePrefab, object1.position, Quaternion.identity);

        Rigidbody cubeRb = cube.GetComponent<Rigidbody>();
        cubeRb.velocity = 10*velocity;

    }
}
