using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenThingy : MonoBehaviour
{
    public Button ButtonPressed;
    public GameObject ThingToOpen;
    
    DbManager dbMgr = DbManager.Instance;
    // Start is called before the first frame update
    void Start()
    {
        ThingToOpen.SetActive(false);
        ButtonPressed.onClick.AddListener(TaskOnClick);
        dbMgr.ReadingData("SELECT*FROM PlayerSaveData");
        
    }
    void TaskOnClick()
    {
        ThingToOpen.SetActive(true);
        
    }

}
