using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public GameObject inventoryMenu;
    public GameObject itemSlot1;

    public GameObject itemSlot2;
    public bool inventoryOpen = false;
public static int NumberOfItems;
public static int NumberOfPotions;
public static bool haveKey;


	void Start () {
        
        inventoryMenu.SetActive(false);
       if(NumberOfItems == 0)
        {
            itemSlot1.SetActive(false);
        }
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
                if (NumberOfItems >= 1)
                {
                    itemSlot1.SetActive(true);
                }
                else
                {
                    if (NumberOfItems == 0)
                    {
                        itemSlot1.SetActive(false);
                    }

                }

            }
        }
    }
    
    
    public void ResumeGame()
    {
        Time.timeScale = 1;
        inventoryOpen = false;
        Cursor.visible = false;
        inventoryMenu.SetActive(false);
        itemSlot1.SetActive(false);
       
    }
}
