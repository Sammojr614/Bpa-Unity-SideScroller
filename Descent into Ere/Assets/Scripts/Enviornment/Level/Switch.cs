using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    public GameObject TrapDoor;
    public GameObject Button;
    public GameObject Floor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Button.SetActive(false);
            DestroyObject(TrapDoor);
            DestroyObject(Floor);
        }
    }
}
