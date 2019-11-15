using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    public GameObject TrapDoor;
    public GameObject Button;
    public GameObject Floor;

    private void OnTriggerEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Button.SetActive(false);
            DestroyObject(TrapDoor);
            DestroyObject(Floor);
        }
    }
}
