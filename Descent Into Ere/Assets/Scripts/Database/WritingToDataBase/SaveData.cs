using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SaveData : MonoBehaviour {
DbManager dataManger = DbManager.Instance;

SpriteRenderer SaveDataRenderer;
void Start(){
	SaveDataRenderer = gameObject.GetComponent<SpriteRenderer>();
	dataManger.TableCheckforRenderer("SELECT*FROM PlayerSaveData", SaveDataRenderer, true, false);
}
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
													/*Main PlayerSaveData */
			//Location
			dataManger.normalDbCommand("UPDATE PlayerSaveData SET PlayerLocation="+  dataManger.PlayerLocation);
			//Health
			dataManger.normalDbCommand("UPDATE PlayerSaveData SET PlayerHealth='"+ Convert.ToInt32(PlayerHealth.health) + "'");
			//Lives
			dataManger.normalDbCommand("UPDATE PlayerSaveData SET PlayerLives='" + Convert.ToInt32(PlayerLives.Lives) + "'");
			dataManger.normalDbCommand("UPDATE PlayerSaveData SET PlayerCurrency='" + Convert.ToInt32(ShopTable.amountOfPlayerCurrency) + "'");
			Debug.Log(ShopTable.amountOfPlayerCurrency);
											/* Currency Counter */
			dataManger.normalDbCommand("UPDATE Money SET FirstDidget='" + Convert.ToInt32(CrystalCounter.FirstDigt) + "'");
			dataManger.normalDbCommand("UPDATE Money SET SecondDidget='" + Convert.ToInt32(CrystalCounter.SecndDigt) + "'");
			dataManger.normalDbCommand("UPDATE Money SET ThirdDidget='"+ Convert.ToInt32(CrystalCounter.ThirdDiget) + "'");
									/*Times Played and Number Of Potions */
			dataManger.normalDbCommand("UPDATE PlayerPerams SET TimesPlayed='" + Convert.ToInt32(TutoralWallCheck.TimesPlayed) + "'");
			dataManger.normalDbCommand("UPDATE PlayerPerams SET NumberOfPotions='" + Convert.ToInt32(Inventory.NumberOfPotions) + "'");
												/* Keys */
			//Boss Key
			if(Inventory.haveBossKey == true){
				dataManger.normalDbCommand("UPDATE KeyTracker SET HaveKey='1' WHERE KeyType='BossKey'");
			}else{
				dataManger.normalDbCommand("UPDATE KeyTracker SET HaveKey='0' WHERE KeyType='BossKey'");
			}
			//Normal Key
			if(Inventory.haveKey == true){
				dataManger.normalDbCommand("UPDATE KeyTracker SET HaveKey='1' WHERE KeyType='NormalKey'");
			}else{
				dataManger.normalDbCommand("UPDATE KeyTracker SET HaveKey='0' WHERE KeyType='NormalKey'");
			}

		}
	}
}
