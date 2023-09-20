using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_attack : MonoBehaviour
{
    private PlayerHealthManager healthManager;
    [SerializeField] GameObject PlayerBody;
    private Transform EnemyBody;

    private float PlayerDistance;
    private Animator animator;
    void Start()
    {
        EnemyBody = GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerDistance = Vector3.Distance(EnemyBody.position, PlayerBody.transform.position);

        if(PlayerDistance < 1)
        {
            
        }
    }
}
