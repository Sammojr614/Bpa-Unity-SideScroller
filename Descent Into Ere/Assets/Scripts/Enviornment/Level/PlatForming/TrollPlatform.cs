using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollPlatform : MonoBehaviour
{
    public GameObject TrollPlatformGameObject;
 void OnTriggerEnter2D(Collider2D collider){
     if(collider.CompareTag("Player")){
         TrollPlatformGameObject.SetActive(false);
     }
 }

}
