using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverContinue : MonoBehaviour
{
    public DbManager dataManager = DbManager.Instance;
    public string SceneName;
 void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayerLives.Lives = 3;
            PlayerHealth.health = 3;
            dataManager.GetSceneNameFromDb("SELECT*FROM PlayerSaveData");
        }
    }
}
