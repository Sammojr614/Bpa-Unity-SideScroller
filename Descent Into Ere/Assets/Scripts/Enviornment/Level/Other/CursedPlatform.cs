using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursedPlatform : MonoBehaviour {

    public static bool canFollow;

    private void Start()
    {
        canFollow = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canFollow = true;
        }
    }
}
