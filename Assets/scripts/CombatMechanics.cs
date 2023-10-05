using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatMechanics : MonoBehaviour
{
    private Animator animator;
    private float attack1timer;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        attack1timer = 2f;
        timer = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        Attackmanager();
        timer += Time.deltaTime;

        if (timer < attack1timer )
        {
            timer += Time.deltaTime;
            animator.SetBool("attack", true);
        }
        else
        {
            animator.SetBool("attack", false);
        }
    }

    public void Attackmanager()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {

            //Debug.Log("Mouse 0 ");
            
            if(animator.GetBool("attack") == false)
            {
                animator.SetBool("attack", true);
                timer = 0f;
            }
        }
    }
}
