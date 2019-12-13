using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicAttack : MonoBehaviour {

    public GameObject magicBall;

    public static float timeBtwAttack = 0f;

    public static bool magicDamage;

    public static bool canAttack;

    private Vector3 MovingDirection = Vector3.right;

	void Start () {
        magicDamage = false;
        canAttack = true;
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(timeBtwAttack <= 0f)
        {
            if(Input.GetButtonDown("ManaAttack") && canAttack == true)
            {
                
            }
        }
    }
}
