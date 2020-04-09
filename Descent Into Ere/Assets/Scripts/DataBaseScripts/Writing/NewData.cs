using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewData : MonoBehaviour
{
    public Button CreateButton;
    DataMgr Data = DataMgr.Instance;
    InventoryMgr Inven = InventoryMgr.Instance;
    public GameObject haveyouPlayedBefore;
    public Button yesButton;
    public Button noButton;

   void Start()
    {
        CreateButton.onClick.AddListener(createOnClick);
        yesButton.onClick.AddListener(YesClick);
        noButton.onClick.AddListener(noOnClick);
    }
    void createOnClick()
    {
        Data.Playerhealth = 4;
        Data.PlayerLives = 3;
        Data.Playercurrency = 0;
        Data.TimesPlayed = 1;
        string newData = JsonUtility.ToJson(Data);
        Inven.ItemName = "Potion";
        Inven.NumberOfItem = 0;
        string invenData = JsonUtility.ToJson(Inven);
        //writing to the Json File
        File.WriteAllText(Application.dataPath + "PlayerSaveData.json", newData);
        File.WriteAllText("PlayerInventory.json", invenData);
        haveyouPlayedBefore.SetActive(true);
    }
    void YesClick()
    {
        SceneManager.LoadScene("MainHub");
    }
    void noOnClick()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
