using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossDoor : MonoBehaviour {

//BossDoor
public GameObject BossDoorOpen;
//Scene where the boss is
public string BossScene;

/* While the player is colliding with
 * The boss door's trigger, and has the boss key
 * The player will enter the boss scene
 */

void OnTriggerStay2D(Collider2D collision){
    if (collision.CompareTag ("Player")) {
        if (Input.GetButton ("EnterDoor") && Inventory.haveBossKey == true) {
            SceneManager.LoadScene (BossScene);
            Inventory.haveBossKey = false;
            if (Inventory.NumberOfItems < 0) {
                    Inventory.NumberOfItems--;
				}
			}
		}
	}

}
