using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    public GameObject inventoryMenu;
    public static bool ItemInItemSlot1;
	public GameObject itemSlot1;
    public GameObject itemSlot2;
	public GameObject itemSlot3;
    public Text YouCantUseThatItem;
    public static bool inventoryOpen = false;
public static int NumberOfItems = 0;
public static int NumberOfPotions = 0;
public static bool haveKey;
public static bool haveBossKey;


	void Start () {
		inventoryMenu.SetActive (false);
		itemSlot1.SetActive (false);
		itemSlot2.SetActive (false);
		itemSlot3.SetActive (false);
        
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
                if(inventoryOpen == true){
                    itemSlot1.SetActive(true);
                }else if(inventoryOpen == false){
                    itemSlot1.SetActive(false);
                }
                if(NumberOfPotions <= 0 && inventoryOpen == true){
                    YouCantUseThatItem.enabled = true;
                }else if(NumberOfPotions > 0){
                    YouCantUseThatItem.enabled = false;
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
       
    }
}
