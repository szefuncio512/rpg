using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("vertical", Input.GetAxis("Vertical"));
        animator.SetFloat("horizontal", Input.GetAxis("Horizontal"));

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetKeyUp(KeyCode.Leftshift))
        {
            Run();
        }

               
          
            
    }

    public void Jump()
    {
        animator.SetTrigger("Jump");
    }

    public void Run()
    {
        animator.SetTrigger("Run");
    }


}
