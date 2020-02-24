using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlain : MonoBehaviour
{
    public Transform PlayerSpawn;
    public Transform PlayerPos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Health.lives--;
            PlayerPos.position = PlayerSpawn.position;
        }
    }
}
