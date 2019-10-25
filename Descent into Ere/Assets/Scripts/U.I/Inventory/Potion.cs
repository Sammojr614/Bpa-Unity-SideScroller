using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour {

    public Animator health;

    public GameObject potion;

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            health.GetComponent<PlayerHealth>().Heal();
            Inventory.NumberOfItems--;
            potion.SetActive(false);
        }
    }
}
