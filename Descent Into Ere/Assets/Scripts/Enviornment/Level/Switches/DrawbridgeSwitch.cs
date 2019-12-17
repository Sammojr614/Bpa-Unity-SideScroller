using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawbridgeSwitch : MonoBehaviour {

    //Switch used to lower the drawbridge
    public GameObject Switch;
    //The Drawbridge while it is up
    public GameObject DrawbridgeUp;
    //The Drawbridge while it is down
    public GameObject DrawbridgeDown;

    /* When the player activates the switch,
     * by entering the switches trigger,
     * the drawbridge will go down,
     * and the switch will dissapear
     */
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Switch.SetActive(false);
            DrawbridgeUp.SetActive(false);
            DrawbridgeDown.SetActive(true);
        }
    }
}
