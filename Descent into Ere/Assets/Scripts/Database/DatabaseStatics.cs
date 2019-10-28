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
                        PlayerHealth.health = Convert.ToInt32(dbReader[2].ToString());
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
    //Loading Level
    public void loadLevelFromDb(string commandText) {
        using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText,dbCon)){
                using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
                    LoadData.PlayerProgress = dbReader[0].ToString();
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
                        PlayerLives.Lives = Convert.ToInt32(dbReader[3].ToString());
                    }
                }
            }
        }
    }
    //Loading all Of the Int data
  public void loadIntData(string connectionString, string commandText){
	using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
		using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
            dbCon.Open();
			using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
				while(dbReader.Read()){
					PlayerHealth.health = Convert.ToInt32(dbReader[2].ToString());
					PlayerLives.Lives = Convert.ToInt32(dbReader[3].ToString());
                        LevelCompletion.LevelComplete = Convert.ToInt32(dbReader[1].ToString());
				}
			}
		}
	}
}
  
    //Testing if The reader is Reading the Data
    public void dbReaderTest(string connectionString, string commandText)
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
                        Debug.Log(dbReader[0].ToString());
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


