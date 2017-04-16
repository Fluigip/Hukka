using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour {

    public float speed;

    private Transform playerPos;
    private Rigidbody fplayer;

    public void Start()
    {
        playerPos = GetComponent<Transform>();
        fplayer = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        
    }

    public void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        fplayer.MovePosition(movement * Time.fixedDeltaTime * speed + playerPos.position);
    }
}
