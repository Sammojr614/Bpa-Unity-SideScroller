using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    DbManager dbMgr = DbManager.Instance;
    //ContinueButton
    [SerializeField] private Button continueButton;
    
    //Will replace this later with the database
    

    public static bool resetLives = false;

    //Required for the button to work
    void Start()
    {
        continueButton.onClick.AddListener(onClick);
    }

    //If the player presses continue, they will return to the previous level
    void onClick()
    {
        //Punishing the Player For Dying 
        if(Shop.PlayerCrystals %2 < 2 && Shop.PlayerCrystals > 0 && Shop.PlayerCrystals%3 < 1)
        {
            string insertifRemander = string.Format("UPDATE PlayerSaveData SET PlayerCurrency ='{0}'", Shop.PlayerCrystals / 3);
            dbMgr.normalDbCommand(insertifRemander);
        }
        else if(Shop.PlayerCrystals > 0 && Shop.PlayerCrystals%2 < 1)
        {
            string insertThis = string.Format("UPDATE PlayerSaveData SET PlayerCurrency = '{0}'", Shop.PlayerCrystals / 2);
            dbMgr.normalDbCommand(insertThis);
        }else if (Shop.PlayerCrystals > 0)
        {
            string insertThistoo = string.Format("UPDATE PlayerSaveData SET PlayerCurrency = '{0}'", Shop.PlayerCrystals - 2);
            dbMgr.normalDbCommand(insertThistoo);
        }

        
        //For Loading the Prev Scene
        dbMgr.LoadSceneFromDb("SELECT*FROM PlayerSaveData");
        resetLives = true;
    }
}
