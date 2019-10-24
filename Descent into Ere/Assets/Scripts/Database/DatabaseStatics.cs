using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;
using System;

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
    //finding Int Data
    public void dbFindIntData(string connectionString, string commandText, int getIntData , int ReaderIndex)
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
                        getIntData = Convert.ToInt32(dbReader[ReaderIndex].ToString());
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
	}


