using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour {

    public float speed;

    private Transform playerPos;

    public void Start()
    {
        playerPos = GetComponent<Transform>();
    }

    public void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        playerPos.position += movement * speed;
    }
}
