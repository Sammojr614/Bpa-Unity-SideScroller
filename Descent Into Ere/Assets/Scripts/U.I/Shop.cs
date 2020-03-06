using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public GameObject ShopMenu;
    ShopMgr Shoppe = ShopMgr.Instance;
    void Start()
    {
        ShopMenu.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetButton("Shop"))
        {
            ShopMenu.SetActive(true);
        }
    }

}
