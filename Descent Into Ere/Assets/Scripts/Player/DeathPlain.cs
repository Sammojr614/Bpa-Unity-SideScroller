using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlain : MonoBehaviour
{
    public Transform PlayerSpawn;
    public Transform PlayerPos;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            PlayerPos.position = PlayerSpawn.position;
            Health.lives--;
        }
    }
}
