using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform playerTransform;
    NavMeshAgent agent;
    private Animator animator;
    [SerializeField] private PlayerHealthManager healthManager;
    private float distance;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        float distance = Vector3.Distance(playerTransform.position, transform.position);
        agent.destination = playerTransform.position;
        if (distance < 4)
        {
            attack();
            animator.SetBool("is_running", false);
            FaceTarget();
            rb.velocity = Vector3.zero;
            
        }
        else
        {
            animator.SetBool("is_running", true);
        }
    }
    void FaceTarget()
    {
        Vector3 direction = (playerTransform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }
    public void attack()
    {
        healthManager.PlayerHealth = healthManager.PlayerHealth - 0.5f;
    }
}