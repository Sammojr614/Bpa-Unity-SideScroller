using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeActive : MonoBehaviour
{
    public SpriteRenderer SpikeRenderer;
void Start(){
   SpikeRenderer.enabled = false;
}
    void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("Player")){
            SpikeRenderer.enabled = true;
        }
    }
    void OnTriggerExit2D(Collider2D collider){
        if(collider.CompareTag("Player")){
            SpikeRenderer.enabled = false;
        }
    }
}
