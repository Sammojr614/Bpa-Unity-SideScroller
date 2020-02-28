using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inherits from the checkpoint class
public class DeathPlain : CheckPoint
{
    //PlayerPos transform
    [SerializeField] private Transform PlayerPos;

    //The Actual Player
    [SerializeField] private GameObject playerObj;

    /* If the player enters the death plain,
     * the player will be sent back to the spawn point,
     * and will have a life deducted (will add later)
     */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /* If the player enters the death plain, 
         * and the player has NOT reached the checkpoint yet,
         * they will be sent back to the beginning of the level
         */
        if (collision.CompareTag("Player") && CheckPoint.checkPointActive == false)
        {
            playerObj.transform.position = PlayerPos.transform.position;
            Health.lives--;
        }
        /* Conversley, if the player enters the death plain,
         * and has reached the checkpoint, they will respawn at the checkpoint
         */
        else if(collision.CompareTag("Player") && CheckPoint.checkPointActive == true)
        {
            playerObj.transform.position = CheckPointPos.transform.position;
            Health.lives--;
        }
    }

}
