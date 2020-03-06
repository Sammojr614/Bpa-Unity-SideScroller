using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MoreDatabasing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerData Save = new PlayerData();
        Save.Health = 4;
        Save.Lives = 3;
        string json = JsonUtility.ToJson(Save);
        //Write to it
        File.WriteAllText(Application.dataPath + "/Json/SaveFile.json",json);
        //Take From it
        string getdata = File.ReadAllText(Application.dataPath + "/Json/SaveFile.json");
        PlayerData loaded =  JsonUtility.FromJson<PlayerData>(getdata);
        Debug.Log("Health Test: Health = " + loaded.Health);
        Debug.Log("Lives Test: Lives = " + loaded.Lives);
        
        
    }

    private class PlayerData
    {
        public int Health;
        public int Lives;
    }
}
