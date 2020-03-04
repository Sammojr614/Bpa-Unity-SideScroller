using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.SceneManagement;

public class DbManager
{
    private static DbManager dbMgr;
    private DbManager()
    {

    }
    public static DbManager Instance
    {
        get
        {
            if (dbMgr == null)
            {
                dbMgr = new DbManager();
            }
            return dbMgr;
        }
    }
    public string connectionString = "Data Source = DieDatabase.db";
    public bool isDataHere;
    public string PlayerLocation;
    public int PlayerHealth;
    public int PlayerLives;
    public int PlayerCurrency;
    public bool slotThere;
    public int PotionsForDisplay;
    public bool LevelNamethere;
    //Normal Database Sqlite Commands
    public void normalDbCommand(string commandText)
    {
        using (SqliteConnection dbCon = new SqliteConnection(connectionString))
        {
            dbCon.Open();
            using (SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon))
            {
                dbCmd.ExecuteNonQuery();
            }
        }
    }
    //Checking for data/Tables
    public void DataCheck(string commandText)
    {
        using (SqliteConnection dbCon = new SqliteConnection(connectionString))
        {
            dbCon.Open();
            using (SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon))
            {
                using (SqliteDataReader dbReader = dbCmd.ExecuteReader())
                {
                    if (dbReader.Read())
                    {
                        Debug.Log("Success!: Data Found!");
                        isDataHere = true;
                    }
                    else
                    {
                        Debug.Log("ERROR!: NO DATA FOUND");
                        isDataHere = false;
                    }
                }
            }
        }
    }
    //Setting Level Stuff
    public void LevelData(string commandText)
    {
        using(SqliteConnection dbCon = new SqliteConnection(connectionString))
        {
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon))
            {
                using (SqliteDataReader dbReader = dbCmd.ExecuteReader())
                {
                    while (dbReader.Read())
                    {
                        if(Convert.ToInt32(dbReader[0]) == 1)
                        {
                            LevelMgr.LevelsComplete = 1;
                        }
                        if(Convert.ToInt32(dbReader[1]) == 1 && Convert.ToInt32(dbReader[0]) == 1)
                        {
                            LevelMgr.LevelsComplete = 2;
                        }
                        if(Convert.ToInt32(dbReader[2])== 1 && Convert.ToInt32(dbReader[1]) == 1 && Convert.ToInt32(dbReader[0]) == 1)
                        {
                            LevelMgr.LevelsComplete = 3;
                        }
                    }
                }
            }
        }
    }
    //Getting all The Data
    public void ReadingData(string commandText)
    {
        using (SqliteConnection dbCon = new SqliteConnection(connectionString))
        {
            dbCon.Open();
            using (SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon))
            {
                using (SqliteDataReader dbReader = dbCmd.ExecuteReader())
                {
                    while (dbReader.Read())
                    {
                        PlayerLocation = dbReader[0].ToString();
                        Health.lives = Convert.ToInt32(dbReader[2]);
                        Health.health = Convert.ToInt32(dbReader[1]);
                        PlayerHealth = Convert.ToInt32(dbReader[1]);
                        PlayerLives = Convert.ToInt32(dbReader[2]);
                        Shop.PlayerCrystals = Convert.ToInt32(dbReader[3]);
                        PlayerCurrency = Convert.ToInt32(dbReader[3]);
                        LoadSaveData.TimesPlayed = Convert.ToInt32(dbReader[4]);
                    }
                }
            }
        }
    }
    //Getting Scene Name Strings From DB
    public void LoadSceneFromDb(string commandText)
    {
        using (SqliteConnection dbCon = new SqliteConnection(connectionString))
        {
            dbCon.Open();
            using (SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon))
            {
                using (SqliteDataReader dbReader = dbCmd.ExecuteReader())
                {
                    while (dbReader.Read())
                    {
                        SceneManager.LoadScene(dbReader[0].ToString());
                    }
                }
            }
        }
    }
    //For Getting Data From That Database that is an Int
    public void getSpesificIntData(string commandText, int IntVar)
    {
        using (SqliteConnection dbCon = new SqliteConnection(connectionString))
        {
            dbCon.Open();
            using (SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon))
            {
                using (SqliteDataReader dbReader = dbCmd.ExecuteReader())
                {
                    while (dbReader.Read())
                    {
                        IntVar = Convert.ToInt32(dbReader[0]);
                    }
                }
            }
        }
    }
    //Getting the Number of Potions.. For Now 
    public void InventoryFromDb(string commandText)
    {
        using (SqliteConnection dbCon = new SqliteConnection(connectionString))
        {
            dbCon.Open();
            using (SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon))
            {
                using (SqliteDataReader dbReader = dbCmd.ExecuteReader())
                {
                    while (dbReader.Read())
                    {
                        Inventory.NumberOfPotions = Convert.ToInt32(dbReader[2]);
                    }
                }
            }
        }
    }
    //Checking if The Slot is There
    public void CheckInventory(string commandText)
    {
        using (SqliteConnection dbCon = new SqliteConnection(connectionString))
        {
            dbCon.Open();
            using (SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon))
            {
                using (SqliteDataReader dbReader = dbCmd.ExecuteReader())
                {
                    if (dbReader.Read())
                    {
                        slotThere = true;
                    }
                    else
                    {
                        slotThere = false;
                    }
                }
            }
            {

            }
        }
    }
    //For the Number of Potions and it's Display
    public void KeepingTrackOfNumbers(string commandText)
    {
        using(SqliteConnection dbCon = new SqliteConnection(connectionString))
        {
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon))
            {
                using(SqliteDataReader dbReader = dbCmd.ExecuteReader())
                {
                    while (dbReader.Read())
                    {
                        Inventory.NumberOfPotions = Convert.ToInt32(dbReader[2]);
                        PotionsForDisplay = Convert.ToInt32(dbReader[2]);
                    }
                }
            }
        }
    }
}