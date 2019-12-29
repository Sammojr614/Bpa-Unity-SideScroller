using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatingPlatform : MonoBehaviour {

    //Minimum and Maximum position
    public float min;
    public float max;
    //Direction the platform is moving
    private Vector3 MovingDirection = Vector3.up;

    public GameObject player;

    //Used to update movement
	void Update () {
        UpdateMovement();
	}

    /* If the platform's y position is
     * Greater than or equal to 5f,
     * Then it will move down,
     * If it's y position is less than,
     * Or equal to 0f, then it will
     * Move up
     */
    void UpdateMovement()
    {
        if (this.transform.position.y >= max)
        {
            MovingDirection = Vector3.down;
        }else if(this.transform.position.y <= min)
        {
            MovingDirection = Vector3.up;
        }
        this.transform.Translate(MovingDirection * Time.smoothDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.transform.Translate(MovingDirection * Time.smoothDeltaTime);
        }
    }
}
