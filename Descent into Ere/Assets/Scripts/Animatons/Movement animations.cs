using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementanimations : MonoBehaviour {

public string animationName;
	
  function Update()
     {

		 if(Input.GetKeyDown("Space"))
      {
       // jumping animation - stops all other animations
       animation.Play(animationName, PlayMode.StopAll);
      }

		 if(Input.GetKeyDown("a"))
      {
       // Plays the walking animation - stops all other animations
       animation.Play(animationName, PlayMode.StopAll);
      }

      if(Input.GetKeyDown("d"))
      {
       // Plays the walking animation - stops all other animations
       animation.Play(animationName, PlayMode.StopAll);
      }
 
 }
