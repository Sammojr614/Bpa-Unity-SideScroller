using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
using Mono.Data.Sqlite;

public class File1Display : MonoBehaviour
{
   DbManager dataManager = DbManager.Instance;
    public Text PlayerLocation;
    public Text Lives;
    public Text Health;
  void Start(){
    GetPlayerLocationFromDb("SELECT*FROM PlayerSaveData");
  }
  //Getting the Player Location
  public void GetPlayerLocationFromDb(string commandText){
    using(SqliteConnection dbCon = new SqliteConnection(dataManager.connectionString)){
      dbCon.Open();
      using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
        using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
          while(dbReader.Read()){
            PlayerLocation.text = dbReader[0].ToString();
          }
        }
      }
    }
  }
  public void GettingHealthForFileDisplay(string commandText){
    using(SqliteConnection dbCon = new SqliteConnection(dataManager.connectionString)){
      dbCon.Open();
      using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
        using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
          while(dbReader.Read()){
            Health.text =  dbReader[3].ToString();
          }
        }
      }
    }
  }
  public void GettingLivesForFileDisplay(string commandText){
    using(SqliteConnection dbCon = new SqliteConnection(dataManager.connectionString)){
      dbCon.Open();
      using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
        using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
          Lives.text = dbReader[4].ToString();
        }
      }
    }
  }
}

