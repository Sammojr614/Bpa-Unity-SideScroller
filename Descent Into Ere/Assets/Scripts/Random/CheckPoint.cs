using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    //Original Spawnpoint and Checkpoint positions
    [SerializeField] protected Transform SpawnPointPos;
    [SerializeField] protected Transform CheckPointPos;

    //SpriteRenderers for the flag, active and unactive
    [SerializeField] private SpriteRenderer flagUnactive;
    [SerializeField] private SpriteRenderer flagActive;

    //Checks if the checkpoint has been reached, this is false by default
    protected static bool checkPointActive = false;

    //On Start, the flag is unactive
    private void Start()
    {
        flagUnactive.enabled = true;
        flagActive.enabled = false;
        checkPointActive = false;
    }
    /* When the player reaches the checkpoint,
     * it updates the spawn point, and sets checkPointActive to true.
     * It also changes the flag's sprite,
     * from unActive, to active.
     */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpawnPointPos.position = CheckPointPos.position;
        flagUnactive.enabled = false;
        flagActive.enabled = true;
        checkPointActive = true;
    }

}
