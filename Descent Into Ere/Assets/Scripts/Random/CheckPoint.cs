using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    //Original Spawnpoint and Checkpoint positions
    [SerializeField] protected Transform SpawnPointPos;
    [SerializeField] protected Transform CheckPointPos;

    //Checks if the checkpoint has been reached, this is false by default
    protected static bool checkPointActive = false;

    /* When the player reaches the checkpoint,
     * it updates the spawn point, and sets checkPointActive to true
     */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpawnPointPos.position = CheckPointPos.position;
        checkPointActive = true;
    }

}
