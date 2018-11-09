using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Combat : MonoBehaviour
{
    static Animator _anim;
    public float speed = 10.0f;

     void Start()
    {
        _anim = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {

        float translation = Input.GetAxis("Vertical") * speed;
       // float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        //straffe *= Time.deltaTime;

        transform.Translate(0, 0, translation);

        if (Input.GetButton("Fire1"))
        {
            _anim.SetBool("isAttacking", true);
        }
        else
            _anim.SetBool("isAttacking", false);

        if (translation != 0)
        {
          //  _anim.SetBool
        }
    }










}
 
