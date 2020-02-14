using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject InventoryMenu;
    public GameObject[] InventorySlots;
    public Button CloseButton;
    public static int NumberOfItems;
    public static int NumberOfPotions;
    // Start is called before the first frame update
    void Start()
    {
        InventoryMenu.SetActive(false);
        CloseButton.onClick.AddListener(CloseOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            InventoryMenu.SetActive(true);
        }
    }
    void CloseOnClick()
    {
        InventoryMenu.SetActive(false);
    }
}
