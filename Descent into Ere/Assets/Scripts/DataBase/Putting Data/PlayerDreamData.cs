using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

public class PlayerDreamData : MonoBehaviour {
	public static int LevelsComplete;

	void Start () {
		IDbConnection dbCon = new SqliteConnection (TitleData.connectionString);
		dbCon.Open ();
		IDbCommand dbCmd = dbCon.CreateCommand ();
		string updateLocation = "UPDATE PlayerSaveData SET PlayerLocation='PlayerDream'";
		dbCmd.CommandText = updateLocation;
		dbCmd.ExecuteNonQuery ();
		bool PlayerDreamComplete = false;
		if (PlayerDreamComplete == true) {
			LevelsComplete = 1;
		}
		IDbCommand levelCmd = dbCon.CreateCommand ();
		//No Levels Complete
		if (LevelsComplete == 0) {
			string noLevelsComplete = "UPDATE LevelData SET Level1='Incomplete', Level2='Incomplete', Level3='Incomplete'";
			levelCmd.CommandText = noLevelsComplete;
			levelCmd.ExecuteNonQuery ();
		} else {
			//One Level Complete
			if (LevelsComplete == 1) {
				string oneLevelComplete = "UPDATE LevelData SET Level1='Complete',Level2='Incomplete', Level3='Incomplete'";
				levelCmd.CommandText = oneLevelComplete;
				levelCmd.ExecuteNonQuery ();
			} else {
				//Two Levels Complete
				if (LevelsComplete == 2) {
					string twoLevelsComplete = "UPDATE LevelData SET Level1='Complete',Level2='Complete',Level3='Incomplete'";
					levelCmd.CommandText = twoLevelsComplete;
					levelCmd.ExecuteNonQuery ();
				} else {
					//Three Levels Complete
					if (LevelsComplete == 3) {
						string threeLevelsComplete = "UPDATE LevelData SET Level1='Complete', Level2='Complete',Level3='Complete'";
						levelCmd.CommandText = threeLevelsComplete;
						levelCmd.ExecuteNonQuery ();
					}
				}
			}
		}
		dbCon.Close ();
	}
}
