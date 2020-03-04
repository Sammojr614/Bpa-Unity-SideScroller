using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteSave : MonoBehaviour
{
    public Button DropButton;
    DbManager dbMgr = DbManager.Instance;
    private void Start()
    {
        DropButton.onClick.AddListener(DeleteOnClick);
    }
    void DeleteOnClick()
    {
        dbMgr.normalDbCommand("DROP TABLE PlayerSaveData");
        dbMgr.normalDbCommand("DROP TABLE LevelIndex");
        dbMgr.normalDbCommand("DROP TABLE PlayerInventory");
    }
}
