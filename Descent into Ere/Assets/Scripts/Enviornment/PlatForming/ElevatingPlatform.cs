using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatingPlatform : MonoBehaviour {

    private Vector3 MovingDirection = Vector3.up;

	void Update () {
        UpdateMovement();
	}

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
