using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSaveData : MonoBehaviour
{
    public Text LocationDisplay;
    public Text HealthDisplay;
    public Text LivesDisplay;
    public Button LoadButton;
    public static string SceneToBeLoaded;
    DbManager datamanager = DbManager.Instance;
    void Start()
    {
        datamanager.ReadingData("SELECT*FROM PlayerSaveData");
        LoadButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        LocationDisplay.text = "Location: " + datamanager.PlayerLocation;
        LivesDisplay.text ="Lives: "+  datamanager.PlayerLives.ToString();
        HealthDisplay.text = "Health: "+ datamanager.PlayerHealth.ToString();
    }
    void TaskOnClick()
    {
        datamanager.LoadSceneFromDb("SELECT*FROM PlayerSaveData");
    }
}
