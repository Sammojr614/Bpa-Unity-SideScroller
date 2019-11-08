using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLRMovement : MonoBehaviour
{
    private Vector3 MovingDirection = Vector3.left;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
    }

    void UpdateMovement(){
        if (this.transform.position.x > 2.4f) {
            MovingDirection = Vector3.left;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        } else if (this.transform.position.x < -2f){
            MovingDirection = Vector3.right;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        this.transform.Translate(MovingDirection * Time.smoothDeltaTime);
    }
}
