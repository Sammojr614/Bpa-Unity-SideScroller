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
	
	



	public string connectionString = "Data Source=DieDataBase.db";
	public string Tableread ="SELECT*FROM PlayerSaveData";

	//General Data Commands
	public void dataCommand(string connectionString, string commandText){
		using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
			dbCon.Open();
			using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
				dbCmd.ExecuteNonQuery();
			}
		}
	}

	//Getting Data Strings From The Database
	public void getDataTypeString(string connectionString, string commandText,string varname, int ReaderIndex){
		using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
			dbCon.Open();
			using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
				using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
					while(dbReader.Read()){
						varname = dbReader[ReaderIndex].ToString();
					}
				}
			}
		}
	}
	//getting Int Data from DataBase
	public void getDataTypeInteger(string connectionString, string commandText, int varname, int ReaderIndex){
		using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
			dbCon.Open();
			using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
				using(IDataReader dbReader = dbCmd.ExecuteReader()){
					while(dbReader.Read()){
						varname = Convert.ToInt32(dbReader[ReaderIndex].ToString());
					}
				}
			}

		}
	}
	}


