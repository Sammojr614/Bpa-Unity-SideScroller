using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    //Arrow
    public GameObject arrow;

    //Max x value
    public float xMax;
    
    //Starting x value
    public float startingPosX;

    //Direction the arrow is moving
    private Vector3 MovingDirection;

    void Start()
    {
        arrow.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
    }

    void UpdateMovement()
    {
        if(this.transform.position.x > startingPosX)
        {
            MovingDirection = Vector3.right;
            this.transform.Translate(MovingDirection * Time.smoothDeltaTime);
            if(this.transform.position.x <= xMax)
            {
                arrow.transform.position.Equals(startingPosX);
            }
        }
        /*
        else
        {
            this.transform.position.x.Equals(startingPosX);
        }
        
        this.transform.Translate(MovingDirection * Time.smoothDeltaTime);
        */

    }
}
