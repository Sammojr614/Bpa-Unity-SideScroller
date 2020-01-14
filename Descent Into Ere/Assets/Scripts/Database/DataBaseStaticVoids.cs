using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;

public class DbManager{
private static DbManager dbMgr;
private DbManager(){

}
public static DbManager Instance{
	get{
		if(dbMgr == null){
			dbMgr = new DbManager();
		}
		return dbMgr;
	}
	
}
public string connectionString = "Data Source = DieDataBase.db";
public string PlayerLocation;
//Use this Void to Get All The int Data From PlayerSave Data And Set it Too
public void gettingSavedIntData(string commandText){
using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
	dbCon.Open();
	using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
		using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
			while(dbReader.Read()){
				//Player Health
			PlayerHealth.health = Convert.ToInt32(dbReader[3].ToString());
			//Player Lives
			PlayerLives.Lives = Convert.ToInt32(dbReader[4].ToString());
			//Currency
			ShopTable.amountOfPlayerCurrency = Convert.ToInt32(dbReader[1].ToString());
			//Number Of Inventory Items
			Inventory.NumberOfItems = Convert.ToInt32(dbReader[2].ToString());
			}
		}
	}
}
}
//For Health Only
public void getHealth(string commandText){
	using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
		dbCon.Open();
		using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
			using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
				while(dbReader.Read()){
					PlayerHealth.health = Convert.ToInt32(dbReader[3].ToString());
				}
			}
		}
	}
}
//For Seeing What Levels Have Been Completed
public void levelCheck(string commandText){
	using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
		dbCon.Open();
		using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
			using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
				while(dbReader.Read()){
					if(Convert.ToInt32(dbReader[0].ToString()) == 1){
						LevelCompletion.LevelComplete = 1;
					}else if(Convert.ToInt32(dbReader[1].ToString())== 1){
						LevelCompletion.LevelComplete = 2;
					}
				}
			}
		}
	}
}
//Working With Other Int Perams
public void setFromPlayerPerams(string commandText){
	using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
		dbCon.Open();
		using(SqliteCommand dbCmd = new SqliteCommand(commandText,dbCon)){
			using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
				while(dbReader.Read()){
					Inventory.NumberOfPotions = Convert.ToInt32(dbReader[0].ToString());
					TutoralWallCheck.TimesPlayed = Convert.ToInt32(dbReader[1].ToString());
				}
			}
		}
	}
}

//Getting Shop Stuff
public void getShopStockFromDb(string commandText){
	using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
		dbCon.Open();
		using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
			using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
				while(dbReader.Read()){
					BuyingStuff.PriceOfItem = Convert.ToInt32(dbReader[2].ToString());
					BuyingStuff.NumberOfItems = Convert.ToInt32(dbReader[3].ToString());
				}
			}
		}
	}
}
//Setting Shop Stuff
public void setShop(string commandText){
	using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
		dbCon.Open();
		using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
			dbCmd.ExecuteNonQuery();
		}
	}
}
//RendererState
public void TableCheckforRenderer(string commandText, SpriteRenderer spriteRenderer, bool ifReaderReads, bool ifReaderDoesntRead){
using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
	dbCon.Open();
	using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
		using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
			if(dbReader.Read()){
				spriteRenderer.enabled = ifReaderReads;
			}else if(!dbReader.Read()){
				spriteRenderer.enabled = ifReaderDoesntRead;
			}
		}
	}
}
}
//For Normal SQL Commands
public void normalDbCommand(string commandText){
	using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
		dbCon.Open();
		using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
			dbCmd.ExecuteNonQuery();
		}
	}
}
//For Loading Scenes, Make Sure You Make a Static Variable to Set As the Scene From Your Script
public void GetSceneNameFromDb(string commandText){
	using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
		dbCon.Open();
		using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
			using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
				while(dbReader.Read()){
					LoadData.LoadScene = dbReader[0].ToString();
				}
			}
		}
	}
	
}
//For Loading the Counter
public void DbCounting( string commandText){
	using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
		dbCon.Open();
		using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
			using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
				while(dbReader.Read()){
					CrystalCounter.ThirdDiget = Convert.ToInt32(dbReader[2].ToString());
					CrystalCounter.SecndDigt = Convert.ToInt32(dbReader[1].ToString());
					CrystalCounter.FirstDigt = Convert.ToInt32(dbReader[0].ToString());
				}
			}
		}
	}
}
//For Testing For data
public void TestForData(string commandText, int readerIndex){
	using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
		dbCon.Open();
		using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
			using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
				if(dbReader.Read()){
					Debug.Log("SUCCESS! Here's What Was Found: " + dbReader[readerIndex].ToString());
				}else if(!dbReader.Read()){
					Debug.Log("ERROR! There is Nothing Here. Try Restarting the Game and Clicking New Save");
				}
			}
		}
	}
}
public void refeshShop(string commandText){
	using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
		dbCon.Open();
		using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
			using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
				while(dbReader.Read()){
					ShopTable.NumberOfItems = Convert.ToInt32(dbReader[3].ToString());
					ShopTable.CostOfItem = Convert.ToInt32(dbReader[2].ToString());
				}
			}
		}
	}
}
public void dbReaderTest(string commandText, int readerIndex){
	using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
		dbCon.Open();
		using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
			using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
				if(dbReader.Read()){
					Debug.Log("SUCCESS! Here's What was Found: " + dbReader[readerIndex].ToString());
				}else if(!dbReader.Read()){
					Debug.Log("ERROR!: DataBase Reader Couldn't Find Anything There.");
				}
			}
		}
	}
}
public void UpgradeCheck(string commandText,int transferBool){
	using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
		dbCon.Open();
		using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
			using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
				while(dbReader.Read()){
					transferBool = Convert.ToInt32(dbReader[3].ToString());
				}
			}
		}
	}
}
}

