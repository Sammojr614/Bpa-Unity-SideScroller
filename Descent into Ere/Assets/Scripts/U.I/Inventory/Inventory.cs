using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public GameObject inventoryMenu;
    public static bool ItemInItemSlot1;
	public GameObject itemSlot1;
    public GameObject itemSlot2;
	public GameObject itemSlot3;
	public GameObject ItemCounter;
    public bool inventoryOpen = false;
public static int NumberOfItems;
public static int NumberOfPotions;
public static bool haveKey;
public static bool haveBossKey;


	void Start () {
        if(NumberOfItems < 0){
            NumberOfItems = 0;
        }
        inventoryMenu.SetActive(false);
       if(NumberOfItems == 0)
        {
            itemSlot1.SetActive(false);
        }
        if(haveKey == true) {
            NumberOfItems++;
        }else{
            if(NumberOfPotions !=1 && Inventory.NumberOfItems !=0){
                NumberOfItems--;

            }
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
				//Boss Key Rendering
				if (haveBossKey == false || inventoryOpen == false) {
					itemSlot3.SetActive (false);
				} else {
					if (inventoryOpen == true && haveBossKey == true) {
						itemSlot3.SetActive (true);
					}
				}

				//Normal Key Rendering 
				if (inventoryOpen == false || haveKey == false) {
					itemSlot2.SetActive (false);
				} else {
					if (inventoryOpen == true && haveKey == true) {
						itemSlot2.SetActive (true);
					}
				}
				//Potion Rendering 
					if (NumberOfItems >= 1 && NumberOfPotions > 1)
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
		itemSlot2.SetActive (false);
		itemSlot3.SetActive (false);
		ItemCounter.SetActive (false);
       
    }
}
