using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour {

    Transform tr_Player;
    float f_RootSpeed = 2.0f;
    float f_MoveSpeed = 2.0f;
	// Use this for initialization
	void Start () {

        tr_Player = GameObject.FindGameObjectWithTag("Player").transform;

	}
	
	// Update is called once per frame
	void Update () {
        /*Look at player*/
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(tr_Player.position - transform.position), f_RootSpeed * Time.deltaTime);

        /*Move at player*/
        transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;

	}
}
