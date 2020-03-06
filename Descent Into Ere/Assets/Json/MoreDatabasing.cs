using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreDatabasing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerData Save = new PlayerData();
        Save.Health = 10;
        Save.Lives = 333;
        string json = JsonUtility.ToJson(Save);
       PlayerData loaded =  JsonUtility.FromJson<PlayerData>(json);
        Debug.Log("Health Test: Health = " + loaded.Health);
    }

    private class PlayerData
    {
        public int Health;
        public int Lives;
    }
}
