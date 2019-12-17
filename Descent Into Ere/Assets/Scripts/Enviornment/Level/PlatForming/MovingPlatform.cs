using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour
{
    //Minimum and Maximum position
    public float min;
    public float max;
    //Direction the platform is moving
    private Vector3 MovingDirection = Vector3.left;

    //Used to update movement
    void Update()
    {
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
        if (this.transform.position.x >= max)
        {
            MovingDirection = Vector3.left;
        }
        else if (this.transform.position.x <= min)
        {
            MovingDirection = Vector3.right;
        }
        this.transform.Translate(MovingDirection * Time.smoothDeltaTime);
    }
}
