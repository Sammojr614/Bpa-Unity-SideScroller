using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour {

    //Minimmum and Maximum length
    public float min;
    public float max;

    //Direction the spike is moving
    private Vector3 MovingDirection = Vector3.back;

	// Update is called once per frame
	void Update () {
        UpdateMovement();
	}

    void UpdateMovement()
    {
        if (this.transform.position.x >= max)
        {
            MovingDirection = Vector3.forward;
        }
        else if (this.transform.position.x <= min)
        {
            MovingDirection = Vector3.back;
        }
        this.transform.Translate(MovingDirection * Time.smoothDeltaTime);
    }
}
