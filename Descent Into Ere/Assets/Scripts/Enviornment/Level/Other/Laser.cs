using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    //SpriteRenderer for the laser
    public SpriteRenderer laser;

    //IceWall that blocks the player from progressing
    public GameObject iceWall;

    //On start, the laser is disabled
    void Start()
    {
        laser.enabled = false;
    }

    /* If the player steps on the trigger platform,
     * a deadly laser is activated, and serves as an obsticle,
     * for the player to avoid, and it destroys the ice wall
     * to allow the player to progress in the level
     */
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            laser.enabled = true;
            iceWall.SetActive(false);
        }
    }
}
