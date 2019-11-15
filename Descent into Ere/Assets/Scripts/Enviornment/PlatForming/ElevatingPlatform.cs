using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatingPlatform : MonoBehaviour {

    //Direction the platform is moving
    private Vector3 MovingDirection = Vector3.up;

    //Used to update movement
	void Update () {
        UpdateMovement();
	}

    /* If the platform's y position is
     * Greater than or equal to 5f,
     * Then it will move down,
     * If it's y position is less than,
     * Or equal to 0f, then it will
     * Move up
     */
    void UpdateMovement()
    {
        if (this.transform.position.y >= 5f)
        {
            MovingDirection = Vector3.down;
        }else if(this.transform.position.y <= 0f)
        {
            MovingDirection = Vector3.up;
        }
        this.transform.Translate(MovingDirection * Time.smoothDeltaTime);
    }
}
