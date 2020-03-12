using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class EraseSave : MonoBehaviour
{
    public Button DropButton;
    DataMgr data = DataMgr.Instance;
    public GameObject EraseDialog;
    public Button YesButton;
    public Button NoButton;
    private void Start()
    {
        EraseDialog.SetActive(false);
        DropButton.onClick.AddListener(OpenDialog);
        YesButton.onClick.AddListener(EraseData);
        NoButton.onClick.AddListener(CloseErase);
    }
    void OpenDialog()
    {
        EraseDialog.SetActive(true);
    }
    void EraseData()
    {
        data.location = "Mainhub";
        data.Playercurrency = 0;
        data.Playerhealth = 4;
        data.PlayerLives = 3;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath +  "PlayerSaveData.json", json);
    }
    void CloseErase()
    {
        EraseDialog.SetActive(false);
    }

}
