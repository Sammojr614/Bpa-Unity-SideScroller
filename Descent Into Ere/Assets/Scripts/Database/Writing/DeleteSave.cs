using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteSave : MonoBehaviour
{
    public Button DropButton;
    public GameObject areYouSure;
    public Button YesButton;
    public Button NoButton;
    DbManager dbMgr = DbManager.Instance;
    private void Start()
    {
        areYouSure.SetActive(false);
        DropButton.onClick.AddListener(confirmDelete);
        NoButton.onClick.AddListener(No);
        YesButton.onClick.AddListener(DeleteOnClick);
    }
    void confirmDelete()
    {
        areYouSure.SetActive(true);
    }
    void No()
    {
        areYouSure.SetActive(false);
    }
    void DeleteOnClick()
    {
        dbMgr.normalDbCommand("DROP TABLE PlayerSaveData");
        dbMgr.normalDbCommand("DROP TABLE LevelIndex");
        dbMgr.normalDbCommand("DROP TABLE PlayerInventory");
        areYouSure.SetActive(false);
    }
}
