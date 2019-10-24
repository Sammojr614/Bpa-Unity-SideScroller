using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour {

    public GameObject potion;

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            potion.GetComponent<PlayerHealth>().Heal();
        }
    }
}
