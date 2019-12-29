using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlipperyPlatform : MonoBehaviour
{

    public GameObject player;

    public bool facingLeft;

    private Vector3 MovingDirection;

    void Start()
    {
        facingLeft = false;
    }

    void Update()
    {
        if (Input.GetButton("MoveRight"))
        {
            facingLeft = false;
        }
        else if (Input.GetButton("MovingLeft"))
        {
            facingLeft = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(facingLeft == true)
            {
                MovingDirection = Vector3.left;
            }
            else if(facingLeft == false)
            {
                MovingDirection = Vector3.right;
            }
            player.transform.Translate(MovingDirection * Time.deltaTime);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (facingLeft == true)
            {
                MovingDirection = Vector3.left;
            }
            else if (facingLeft == false)
            {
                MovingDirection = Vector3.right;
            }
            player.transform.Translate(MovingDirection * Time.deltaTime);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
