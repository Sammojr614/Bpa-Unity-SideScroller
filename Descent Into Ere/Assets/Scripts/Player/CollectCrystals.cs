using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCrystals : MonoBehaviour
{
    public GameObject Crystal;
    DbManager dataMgr = DbManager.Instance;
    private void Start()
    {
        Crystal.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Crystal"))
        {
            Shop.PlayerCrystals++;
            Crystal.SetActive(false);
            string insertThis = string.Format("UPDATE PlayerSaveData SET PlayerCurrency='{0}'", Shop.PlayerCrystals);
            dataMgr.normalDbCommand(insertThis);
        }
    }
}
