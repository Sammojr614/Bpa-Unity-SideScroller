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

    //On start, the arrow is fired
    void Start()
    {
        arrow.SetActive(true);
    }

    // Updates movement of the arrow
    void Update()
    {
        UpdateMovement();
    }

    /* Once the arrow shoots, it moves to the right,
     * until it reaches a cerain point (xMax),
     * then, it goes back to the starting position, and fires again to the right
     */
    void UpdateMovement()
    {
        if(this.transform.position.x < xMax)
        {
            MovingDirection = Vector3.right;
            this.transform.Translate(MovingDirection * Time.smoothDeltaTime * 2.5f);
        }
        else
        {
            MovingDirection = Vector3.left;
            this.transform.Translate(MovingDirection * 10);
        }

    }
}
