using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Follow : MonoBehaviour {

    public Transform player;
    Animator anim;
    //bool pursuing = false;

   // string state = "patrol";
    //public GameObject[] waypoints;
    //int currentWP = 0;
    //public float rotSpeed = 0.2f;
    public float speed = 1.5f;
   // float accuraccyWP = 5.0f;

	
	void Start () {
        anim = GetComponent<Animator>();
		
	}
	
	
	void Update () {
        Vector3 direction = player.position - this.transform.position;
        direction.y = 0;
        float angle = Vector3.Angle(direction, this.transform.forward);

        /*if ( state == "patrol" && waypoints.Length > 0)
        {
            anim.SetBool("isIdle", false);
            anim.SetBool("isWalking", true);
            if (Vector3.Distance(waypoints[currentWP].transform.position, transform.position) < accuraccyWP)
            {
                currentWP = Random.Range(0, waypoints.Length);
               currentWP++;
                if(currentWP >= waypoints.Length)
                {
                    currentWP = 0;
                }
            }
            //rotate towards waypoint 
            direction = waypoints[currentWP].transform.position - transform.position;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), rotSpeed * Time.deltaTime);
            this.transform.Translate(0, 0, Time.deltaTime * speed);
        }*/

           
            if (Vector3.Distance(player.position, this.transform.position) < 4 && angle < 35 )
            {
                 //state = "pursuing";
                 this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), speed * Time.deltaTime);

                 anim.SetBool("isIdle", false);
                if (direction.magnitude > 5)
                {
                    this.transform.Translate(0, 0, Time.deltaTime *speed);
                    anim.SetBool("Walking", true);
                    anim.SetBool("attacking", false);
                }
                 else
                    {
                        anim.SetBool("attacking", true);
                        anim.SetBool("Walking", false);
                    }
            }

        else
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("Walking", false);
            anim.SetBool("attacking", false);
           // state = "patrol";
        }
        
	}
}
