using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlain : MonoBehaviour
{
    //PlayerSpawn and PlayerPos transforms
    [SerializeField] private Transform PlayerSpawn;
    [SerializeField] private Transform PlayerPos;

    //The Actual Player
    [SerializeField] private GameObject playerObj;

    /* If the player enters the death plain,
     * the player will be sent back to the spawn point,
     * and will have a life deducted (will add later)
     */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerObj.transform.position = PlayerSpawn.transform.position;
        }
    }

    /* When the player exits the death plain,
     * the player's position will return to it's normal position
     */
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerObj.transform.position = PlayerPos.transform.position;
        }
    }
}
