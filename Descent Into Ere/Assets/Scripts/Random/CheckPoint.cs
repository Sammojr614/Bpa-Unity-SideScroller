using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    //The Database manager
    DbManager dbMgr = DbManager.Instance;
    //Original Spawnpoint and Checkpoint positions
    [SerializeField] protected Transform SpawnPointPos;
    [SerializeField] protected Transform CheckPointPos;

    //SpriteRenderers for the flag, active and unactive
    [SerializeField] private SpriteRenderer flagUnactive;
    [SerializeField] private SpriteRenderer flagActive;
    public static bool activeCheckpoint;

    //Checks if the checkpoint has been reached, this is false by default
    protected static bool checkPointActive = false;

    //Zach, I have Updated the Database so that it will save if the player has the Checkpoint. I Will make you a DbCheck for it.
    private void Start()
    {
        // checking if the Checkpoint is true or false in the database
        string insertThis = string.Format("SELECT*FROM LevelIndex WHERE LevelName = '{0}'", dbMgr.PlayerLocation);
        dbMgr.CheckpointCheck(insertThis);
        if(activeCheckpoint == true)
        {
            SpawnPointPos.position = CheckPointPos.position;
            flagActive.enabled = true;
            flagUnactive.enabled = false;
        }else if(activeCheckpoint == false)
        {
            flagUnactive.enabled = true;
            flagActive.enabled = false;
        }
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
        activeCheckpoint = true;
        string insertThis = string.Format("UPDATE LevelIndex SET Checkpoint = '1' WHERE LevelName ='{0}'", dbMgr.PlayerLocation);
        dbMgr.normalDbCommand(insertThis);
    }

}
