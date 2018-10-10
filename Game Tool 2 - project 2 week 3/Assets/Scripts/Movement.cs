using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Animator m_animator;


	// Use this for initialization
	void Start () {
        //initialize animator
        m_animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame


    public void Move(float Turn, float Forward)
    {
        //Control Animation Movement
        m_animator.SetFloat("Turn", Turn);
        m_animator.SetFloat("Forward", Forward);

    }
}
