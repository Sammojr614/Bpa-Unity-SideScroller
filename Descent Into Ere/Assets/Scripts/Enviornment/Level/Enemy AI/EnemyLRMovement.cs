using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLRMovement : MonoBehaviour
{
    //Moving Direction
    private Vector3 MovingDirection = Vector3.left;

    //Minimum x position for the enemy
    public float xMin;
    //Maximum x position for the enemy
    public float xMax;


    // Updates the enemies movement
    void Update()
    {
        UpdateMovement();
    }

    /* If the enemy's x position is greater than the max,
     * the enemy will move left, and the sprite renderer will flip.
     * Conversly, if the enemy's x position is less than the min,
     * the enemy will move right, and the sprite renderer will flip back to the original
     */
    void UpdateMovement(){
        if (this.transform.position.x > xMax) {
            MovingDirection = Vector3.left;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        } else if (this.transform.position.x < xMin){
            MovingDirection = Vector3.right;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        this.transform.Translate(MovingDirection * Time.smoothDeltaTime);
    }
}
