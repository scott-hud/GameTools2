using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour {

    private float m_Turn;
    private float m_Forward;
    private Movement m_movement;

    // Use this for initialization
    void Start() {
        m_movement = GetComponent<Movement>();

    }

    // Update is called once per frame
    void FixedUpdate() {
        m_Turn = Input.GetAxis("Horizontal");
        m_Forward = Input.GetAxis("Vertical");
        m_movement.Move(m_Turn, m_Forward);
    }

 
}
