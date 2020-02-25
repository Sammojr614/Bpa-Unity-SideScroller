using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlain : MonoBehaviour
{
    public Transform PlayerSpawn;
    public Transform PlayerPos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*All This Does is Put the Player at the Given SpawnPoint if He is To Touch this object's Collider*/
        if (collision.CompareTag("Player"))
        {
            Health.lives--;
            PlayerPos.position = PlayerSpawn.position;
        }
    }
}
