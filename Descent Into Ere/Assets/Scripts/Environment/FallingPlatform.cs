using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    //Starting position of the platform
    private Vector3 startPos;

    private bool falling = false;

    //The max distance the platform can fall
    [SerializeField] private float maxFall;

    //The Falling Platform
    [SerializeField] private Rigidbody2D fallingFloater;

    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
    }

    //If the platform reaches its max fall value, it will return to it's original position
    void Update()
    {
        Fall();

        if(this.transform.position.y <= maxFall)
        {
            falling = false;
            this.transform.position = startPos;
        }
    }

    //When the player jumps on the falling platform, it will start falling
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            falling = true;
        }
    }

    //While the player is on the platform, it will continue falling
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            falling = true;
        }
    }

    /* Method that determines if the platform is falling.
     * If falling is true, the platform will fall,
     * it falling is false, the platform will stop falling, and return to it's original position
     */
    void Fall()
    {
        switch (falling)
        {
            case true:
                {
                    fallingFloater.isKinematic = false;
                    fallingFloater.constraints = RigidbodyConstraints2D.None;
                    fallingFloater.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
                break;
            case false:
                {
                    fallingFloater.isKinematic = true;
                    fallingFloater.constraints = RigidbodyConstraints2D.FreezePositionY;
                    fallingFloater.constraints = RigidbodyConstraints2D.FreezeRotation;
                }
                break;
        }
    }
}
