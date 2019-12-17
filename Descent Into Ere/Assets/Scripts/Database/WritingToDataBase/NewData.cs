using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewData : MonoBehaviour {
	SpriteRenderer NewDataRenderer;
DbManager dataManger = DbManager.Instance;
void Start(){
	NewDataRenderer = gameObject.GetComponent<SpriteRenderer>();
	dataManger.TableCheckforRenderer("SELECT*FROM PlayerSaveData",NewDataRenderer, false, true);
}
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
													/*Main PlayerSave */
			//Creating the MainPlayer Save Table
			dataManger.normalDbCommand("CREATE TABLE PlayerSaveData(PlayerLocation TEXT, PlayerCurrency INTEGER,ItemsInInventory INTEGER,PlayerHealth INTEGER, PlayerLives INTEGER)");
			//Inserting The Data
			dataManger.normalDbCommand("INSERT INTO PlayerSaveData(PlayerLocation,PlayerCurrency,ItemsInInventory, PlayerHealth,PlayerLives) VALUES('Tutoral1','0','0','3','3')");
											/*Level Tracker */
			//Creating The Index
			dataManger.normalDbCommand("CREATE TABLE Levels(PlayerDream INTEGER, Lucid INTEGER, Level3 INTEGER)");
			//Inserting Data
			dataManger.normalDbCommand("INSERT INTO Levels(PlayerDream, Lucid, Level3) VALUES('0','0','0')");
											/*Switch Tracker */
			//Creating the Switch Index
			dataManger.normalDbCommand("CREATE TABLE Switches(SwitchId INTEGER, SwitchLocation TEXT, SwitchType TEXT)");
										/*Shop Table */
			//Creating the Table
			dataManger.normalDbCommand("CREATE TABLE ShopStock(ItemId INTEGER,Item TEXT, ItemPrice INTEGER, amountOfItem INTEGER)");
			dataManger.normalDbCommand("INSERT INTO ShopStock(ItemId, Item, ItemPrice,amountOfItem) VALUES('0','Potion','5','3')");
										/* Money Counter */
			dataManger.normalDbCommand("CREATE TABLE Money(FirstDidget INTEGER, SecondDidget INTEGER, ThirdDidget INTEGER)");
			dataManger.normalDbCommand("INSERT INTO Money(FirstDidget, SecondDidget, ThirdDidget) VALUES('0','0','0')");
			SceneManager.LoadScene("Tutoral1");
											/*Key Manager */
			dataManger.normalDbCommand("CREATE TABLE KeyTracker(KeyType TEXT, HaveKey INTEGER)");
			dataManger.normalDbCommand("INSERT INTO KeyTracker(KeyType, HaveKey) VALUES('NormalKey','0')");
			dataManger.normalDbCommand("INSERT INTO KeyTracker(KeyType, HaveKey) VALUES('BossKey','0')");
								/*Other Player Save Stuff */
			dataManger.normalDbCommand("CREATE TABLE PlayerPerams(NumberOfPotions INTEGER, TimesPlayed INTEGER)");
			dataManger.normalDbCommand("INSERT INTO PlayerPerams(NumberOfPotions, TimesPlayed) VALUES('0','0')");
									/* Upgrades */
			dataManger.normalDbCommand("CREATE TABLE Upgrades(NameOfUpgrade TEXT, ItemUpgraded TEXT, ItemUpgradeIncrease INTEGER, PlayerHave INTEGER)");
			dataManger.normalDbCommand("INSERT INTO Upgrades(NameOfUpgrade,ItemUpgraded,ItemUpgradeIncrease, PlayerHave) VALUES('KnifeUpgrade', 'ButterKnife', '2', '0')");


		}
	}
}
