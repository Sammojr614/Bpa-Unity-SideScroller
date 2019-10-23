using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public GameObject inventoryMenu;
    public bool inventoryOpen = false;


	void Start () {
        inventoryMenu.SetActive(false);
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (inventoryOpen)
            {
                ResumeGame();
            }
            else
            {
                Time.timeScale = 0;
                inventoryOpen = true;
                Cursor.visible = true;
                inventoryMenu.SetActive(true);
            }
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        inventoryOpen = false;
        Cursor.visible = false;
        inventoryMenu.SetActive(false);
    }
}
