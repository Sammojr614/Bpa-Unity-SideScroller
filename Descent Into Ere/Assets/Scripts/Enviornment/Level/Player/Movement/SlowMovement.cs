using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMovement : MonoBehaviour
{

    private float moveSpeed;
    // Movespeed is 1f on start
    void Start()
    {
        moveSpeed = 1f;
    }

    // Slows the players movement drastically
    void Update()
    {
        Vector3 movementRight = new Vector3(Input.GetAxis("MoveRight"), 0f, 0f);
        transform.position += movementRight * Time.deltaTime * moveSpeed;

        Vector3 movementLeft = new Vector3(Input.GetAxis("MoveLeft"), 0f, 0f);
        transform.position += movementLeft * Time.deltaTime * moveSpeed;
    }
}
