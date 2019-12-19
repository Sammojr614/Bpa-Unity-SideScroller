using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeActive : MonoBehaviour
{

    public GameObject spike;

    //On start, the spike is hidden
    void Start()
    {
        spike.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            spike.SetActive(true);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            spike.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        spike.SetActive(false);
    }
}
