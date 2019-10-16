using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

public class LucidData : MonoBehaviour {

	// Use this for initialization
	void Start () {
		IDbConnection dbCon = new SqliteConnection (TitleData.connectionString);
		dbCon.Open ();
		IDbCommand dbCmd = dbCon.CreateCommand ();
		bool LucidComplete = false;
		if (LucidComplete == true) {
			PlayerDreamData.LevelsComplete = 2;
		}
		string UpdateLocation = "UPDATE PlayerSaveData SET PlayerLocation='Lucid'";
		dbCmd.CommandText = UpdateLocation;
		dbCmd.ExecuteNonQuery ();
		IDbCommand levelCmd = dbCon.CreateCommand ();
		if (PlayerDreamData.LevelsComplete == 0) {
			string noLevelsComplete = "UPDATE LevelData SET Level1='Incomplete', Level2='Incomplete', Level3='Incomplete'";
			levelCmd.CommandText = noLevelsComplete;
			levelCmd.ExecuteNonQuery ();
		} else {
			if (PlayerDreamData.LevelsComplete == 1) {
				string oneLevelComplete = "UPDATE LevelData SET Level1='Complete',Level2='Incomplete', Level3='Incomplete'";
				levelCmd.CommandText = oneLevelComplete;
				levelCmd.ExecuteNonQuery ();
			} else {
				if (PlayerDreamData.LevelsComplete == 2) {
					string twoLevelsComplete = "UPDATE LevelData SET Level1='Complete',Level2='Complete',Level3='Incomplete'";
					levelCmd.CommandText = twoLevelsComplete;
					levelCmd.ExecuteNonQuery ();
				} else {
					if (PlayerDreamData.LevelsComplete == 3) {
						string threeLevelsComplete = "UPDATE LevelData SET Level1='Complete', Level2='Complete',Level3='Complete'";
						levelCmd.CommandText = threeLevelsComplete;
						levelCmd.ExecuteNonQuery ();
					}
				}

	}

}
	}
}
