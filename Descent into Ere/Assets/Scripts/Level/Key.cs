using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    public GameObject key;
    public GameObject Obsticle;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DestroyObject(Obsticle);
            key.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DestroyObject(Obsticle);
            key.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
