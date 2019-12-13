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
        if (Input.GetButtonDown("ManaAttack") && canAttack == true)
        {
            for (int i = 0; i < 200; i++)
            {
                if (this.transform.position.x >= -4f)
                {
                    MovingDirection = Vector3.right;
                }
                this.transform.Translate(MovingDirection * Time.smoothDeltaTime);
                if (collision.CompareTag("Enemy"))
                {
                    magicDamage = true;
                    magicBall.SetActive(false);

                }
                else
                {
                    magicDamage = false;
                    magicBall.SetActive(true);
                }
            }
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetButtonDown("ManaAttack") && canAttack == true)
        {
            for (int i = 0; i < 200; i++)
            {
                if (this.transform.position.x >= -4f)
                {
                    MovingDirection = Vector3.right;
                }
                this.transform.Translate(MovingDirection * Time.smoothDeltaTime);
                if (collision.CompareTag("Enemy"))
                {
                    magicDamage = true;
                    magicBall.SetActive(false);

                }
                else
                {
                    magicDamage = false;
                    magicBall.SetActive(true);
                }
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {

    }


    void Update()
    {
        UpdateMovement();
        if (magicBall.CompareTag("Enemy"))
        {
            magicDamage = true;
            if(magicDamage == true)
            {
                magicBall.SetActive(false);
            }
        }
    }

    void UpdateMovement()
    {
        if (Input.GetButton("ManaAttack"))
        {
            for (int i = 0; i < 105; i++)
            {
                if (this.transform.position.x >= -4f)
                {
                    MovingDirection = Vector3.right;
                }
                this.transform.Translate(MovingDirection * Time.smoothDeltaTime);
                /*
                if (magicBall.CompareTag("Enemy"))
                {
                    magicDamage = true;
                    magicBall.SetActive(false);
                }
                else
                {
                    magicDamage = false;
                    magicBall.SetActive(true);
                }
                */
            }
        }
    }

}
