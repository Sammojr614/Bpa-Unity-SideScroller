using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class LoadPress : MonoBehaviour
{
    DataMgr data = DataMgr.Instance;
    public Button loadButton;
    public GameObject TutorialDialog;
    // Start is called before the first frame update
    void Start()
    {
        loadButton.onClick.AddListener(LoadOnClick);
        TutorialDialog.SetActive(false);
    }
    void LoadOnClick()
    {
        string forload = File.ReadAllText(Application.dataPath + "/Database/PlayerSaveData.json");
        DataMgr Loaded = JsonUtility.FromJson<DataMgr>(forload);
        SceneManager.LoadScene(Loaded.location);
        Health.health = Loaded.Playerhealth;
        Health.lives = Loaded.PlayerLives;
        data.TimesPlayed++;
        string updateTimesPlayed = JsonUtility.ToJson(data);
        File.WriteAllText(Application.dataPath + "/Database/PlayerSaveData.json", updateTimesPlayed);
        if(Loaded.TimesPlayed < 1)
        {
            TutorialDialog.SetActive(true);
        }
        else
        {
            TutorialDialog.SetActive(false);
        }
    }

    
}
