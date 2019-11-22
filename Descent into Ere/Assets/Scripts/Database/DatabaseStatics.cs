using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using System;
using UnityEngine.SceneManagement;

public class DbManager {
	private static DbManager dbMgr;

private DbManager(){

}
public static DbManager Instance {
	get{
		if(dbMgr == null){
			dbMgr = new DbManager();
		}
		return dbMgr;
	}
	}

    public string connectionString = "Data Source= DieDataBase.db";
    public int TrueOrFalseFromdb;
    public int BosskeyTrueOrFalse;
	public string NameOfItem;
	public int CostofItem;
	public int NumberOfItem;

    //General Commands
    public void dbCommand(string connectionString, string commandText) {
        using (SqliteConnection dbCon = new SqliteConnection(connectionString))
        {
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon))
            {
                dbCmd.ExecuteNonQuery();
            }
        }
    }
    //Seeing if a String is Equal
    public void dbFindEqualString(string commandText,string lookingForThisString,bool ItemInSlot1){
        using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
                using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
                    while(dbReader.Read()){
                        if(dbReader[0].ToString() == lookingForThisString){
                            ItemInSlot1 = true;
                        }else{
                            ItemInSlot1 = false;
                        }
                    }
                }
            }
        }
    }
    //find String Data
    public void dbFindStringData(string connectionString,string commandText,string getStringData,int readerIndex)
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
                        getStringData = dbReader[readerIndex].ToString();
                        
                    }
                }
            }
        }
    }
    //Loading Health
    public void getHealthFromDb(string connectionString, string commandText){
        using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
                using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
                    while(dbReader.Read()){
                        PlayerHealth.health = Convert.ToInt32(dbReader[6].ToString());
                    }
                }
            }
        }
    }
    //Loading Normal Strings
    public void loadStringFromDb(string connectionString, string commandText, string VarName, int readerIndex){
        using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
            dbCon.Open();
            using(SqliteCommand dbComd = new SqliteCommand(commandText,dbCon)){
                using(SqliteDataReader dbReader = dbComd.ExecuteReader()){
                    while(dbReader.Read()){
                        VarName = dbReader[readerIndex].ToString();
                    }
                }
            }
        }
    }
    //Loading Lives
    public void getLivesFromDb(string connectionString,string commandText){
        using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
            using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
                dbCon.Open();
                using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
                    while(dbReader.Read()){
                        PlayerLives.Lives = Convert.ToInt32(dbReader[7].ToString());
                    }
                }
            }
        }
    }
	//Getting Shop Stuff
	public void getShopStockFromDb(string commandText){
		using (SqliteConnection dbCon = new SqliteConnection (connectionString)) {
			dbCon.Open ();
			using (SqliteCommand dbCmd = new SqliteCommand (commandText, dbCon)) {
				using (SqliteDataReader dbReader = dbCmd.ExecuteReader ()) {
					while (dbReader.Read ()) {
						ShopTable.NameOfItem = dbReader [0].ToString ();
						ShopTable.CostOfItem = Convert.ToInt32 (dbReader [2].ToString ());
						ShopTable.NumberOfItems = Convert.ToInt32 (dbReader [1].ToString ());
					}
				}
			}
		}
	}
    //Loading all Of the Int data From PlayerSave Data
  public void loadIntData(string connectionString, string commandText){
	using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
		using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
            dbCon.Open();
			using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
				while(dbReader.Read()){
                    //Getting health
					PlayerHealth.health = Convert.ToInt32(dbReader[6].ToString());
                    //Getting Lives
					PlayerLives.Lives = Convert.ToInt32(dbReader[7].ToString());
                    //Getting if player has Key
                    TrueOrFalseFromdb = Convert.ToInt32(dbReader[4].ToString());
                    //Levels Complete
                        LevelCompletion.LevelComplete = Convert.ToInt32(dbReader[1].ToString());
                        //NumberOfItemsIn Inventory
                        Inventory.NumberOfItems = Convert.ToInt32(dbReader[2].ToString());
                        //getting if player has Boss key
                        BosskeyTrueOrFalse = Convert.ToInt32(dbReader[5].ToString());
                        //Getting NumberOf Potions
                        Inventory.NumberOfPotions = Convert.ToInt32(dbReader[3].ToString());
                        //Getting Number of Times Played
                        TutoralWallCheck.TimesPlayed = Convert.ToInt32(dbReader[8].ToString());
                        //Gettin Them Moneys
                       ShopTable.amountOfPlayerCurrency = Convert.ToInt32(dbReader[9].ToString());
						//Saying what is In the Shop And What the Cost


				}
			}
		}
	}
}

  
    //Testing if The reader is Reading the Data
    public void dbReaderTest(string connectionString, string commandText, int readerIndex)
    {
        using(SqliteConnection dbCon = new SqliteConnection(connectionString))
        {
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon))
            {
                using (SqliteDataReader dbReader = dbCmd.ExecuteReader())
                {
                    if (dbReader.Read())
                    {
                        Debug.Log("SUCCESS!: Data Found! Here's What is There: "+ dbReader[readerIndex].ToString());
                        
                    }
                    else
                    {
                        Debug.Log("ERROR: Data not Found");
                    }
                }
            }
        }
    }
    //For Loading Scene Names From The DataBase
    public void loadSceneFromDB(string connectionString, string commandText, string SceneName){
        using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText,dbCon)){
                using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
                    while(dbReader.Read()){
                        SceneName = dbReader[0].ToString();
                        SceneManager.LoadScene(SceneName);
                    }
                }
            }
        }
    }
    //Changing Renderer State
    public void RendererState(string connectionString, string commandText, SpriteRenderer spriteRenderer,bool ifReaderisReading, bool ifReaderisntReading){
        using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText,dbCon)){
                using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
                    if(dbReader.Read()){
                        spriteRenderer.enabled = ifReaderisReading;
                    }else{
                        spriteRenderer.enabled = ifReaderisntReading;
                    }
                }
            }
        }
    }
	}


