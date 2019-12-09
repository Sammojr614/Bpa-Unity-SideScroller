using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {

    //The floor holding up the wall
    public GameObject FakeFloor;

    /* When the player steps on the trap floor,
     * A fake floor is destroyed, and a
     * wall falls down, to force the player
     * progress through the level, 
     * to destroy the wall
     */
    void OnTriggerEnter2D(Collider2D collision)
    {
        DestroyObject(FakeFloor);
    }
}
