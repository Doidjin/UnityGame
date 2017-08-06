using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name){
		Debug.Log ("Level game requested for: " + name);
		Application.LoadLevel (name);
	}

	public void QuitArguments(){
		Debug.Log("I wanna quit!");
		Application.Quit ();
	}
}
