using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackManager : MonoBehaviour {

	public void Back (string name){

		Debug.Log("Backing to the Start Scene!");
		Application.LoadLevel (name);
	}
}
