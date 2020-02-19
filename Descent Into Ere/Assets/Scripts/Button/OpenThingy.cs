using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenThingy : MonoBehaviour
{
    public Button ButtonPressed;
    public GameObject ThingToOpen;
    public static int TimesPlayed;
    DbManager dbMgr = DbManager.Instance;
    // Start is called before the first frame update
    void Start()
    {
        dbMgr.ReadingData("SELECT*FROM PlayerSaveData");
        ThingToOpen.SetActive(false);
        ButtonPressed.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        ThingToOpen.SetActive(true);
        TimesPlayed++;
        string InsertingTimesPlayied = string.Format("UPDATE PlayerSaveData SET TimesPlayed = '{0}'", TimesPlayed);
        dbMgr.normalDbCommand(InsertingTimesPlayied);
        
    }

}
