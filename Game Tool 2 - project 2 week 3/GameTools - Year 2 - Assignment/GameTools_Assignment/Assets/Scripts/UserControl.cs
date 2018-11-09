using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour
{
    private float m_turn;
    private float m_forward;
    private bool m_jump;
    private bool m_slash;
    private bool m_kick;




    private Character m_character;
    // Use this for initialization
    void Start()
    {
        m_character = GetComponent<Character>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get user Input.
        m_turn = Input.GetAxis("Horizontal");
        m_forward = Input.GetAxis("Vertical");
        m_jump = Input.GetButtonDown("Jump");
       // m_slash = Input.GetMouseButtonDown(0);
        m_kick = Input.GetKey(KeyCode.K);


        m_character.Move(m_turn, m_forward, m_jump);
    }
}

 
