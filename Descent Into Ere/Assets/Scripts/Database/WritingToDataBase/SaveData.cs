using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SaveData : MonoBehaviour {
DbManager dataManger = DbManager.Instance;
public static string PlayerLocation;

SpriteRenderer SaveDataRenderer;
void Start(){
	SaveDataRenderer = gameObject.GetComponent<SpriteRenderer>();
	dataManger.TableCheckforRenderer("SELECT*FROM PlayerSaveData", SaveDataRenderer, true, false);
}
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
													/*Main PlayerSaveData */
			//Location
			dataManger.normalDbCommand("UPDATE PlayerSaveData SET PlayerLocation='"+ PlayerLocation +"'");
			//Health
			dataManger.normalDbCommand("UPDATE PlayerSaveData SET PlayerHealth='"+ Convert.ToInt32(PlayerHealth.health) + "'");
			//Lives
			dataManger.normalDbCommand("UPDATE PlayerSaveData SET PlayerLives='" + Convert.ToInt32(PlayerLives.Lives) + "'");
											/* Currency Counter */
			dataManger.normalDbCommand("UPDATE Money SET FirstDidget='" + Convert.ToInt32(CrystalCounter.ThirdDiget) + "'");
			dataManger.normalDbCommand("UPDATE Money SET SecondDidget='" + Convert.ToInt32(CrystalCounter.FirstDigt) + "'");
			dataManger.normalDbCommand("UPDATE Money SET ThirdDidget='"+ Convert.ToInt32(CrystalCounter.SecndDigt) + "'");

		}
	}
}
