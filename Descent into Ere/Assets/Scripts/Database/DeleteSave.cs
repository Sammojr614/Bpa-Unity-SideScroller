using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSave : MonoBehaviour {

//This is For All Of the Db Scripts Used Here
	DbManager dataManager = DbManager.Instance;
	SpriteRenderer DeleteFile;
	void Start(){
		DeleteFile = gameObject.GetComponent<SpriteRenderer>();
		dataManager.RendererState(dataManager.connectionString,"SELECT*FROM PlayerSaveData",DeleteFile, true,false);
	}
	void OnMouseDown(){
		if(Input.GetMouseButtonDown(0)){
			// As the Name of the Script Implies It Deletes the data
			dataManager.dbCommand(dataManager.connectionString, "DROP TABLE PlayerSaveData");
		}
	}
}
