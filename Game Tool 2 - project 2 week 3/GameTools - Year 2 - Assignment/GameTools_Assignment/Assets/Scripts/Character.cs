using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Animator m_animator;

    public float maxSpeed = 50;

    // Use this for initialization
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Move(float Turn, float Forward, bool jump)
    {

        m_animator.SetFloat("Turn", Turn);
        m_animator.SetFloat("Forward", Forward);

        if (jump)
        {
            m_animator.SetTrigger("Jump");
        }
        // transform.position = Vector3.forward * maxSpeed * Time.deltaTime;



        if (Input.GetButton("Fire1"))
        {
            m_animator.SetBool("isAttacking", true);
        }
        else
            m_animator.SetBool("isAttacking", false);
    }
}
//}
