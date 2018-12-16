using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    private GameObject player;
    private float xRotate, yRotate;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update () {
        xRotate = Input.GetAxis("Mouse X"); 
        yRotate += Mathf.Min(50, Mathf.Max(-50, xRotate + Input.GetAxis("Mouse Y")));
        //player.transform.localRotation = Quaternion.Euler(0, xRotate, 0);
        player.transform.localRotation = Quaternion.Euler(0, xRotate, 0);
        transform.localRotation = Quaternion.Euler(yRotate, 0, 0);
    }
}
