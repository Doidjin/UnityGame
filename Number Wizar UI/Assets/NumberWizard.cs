using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;

	int maxGuessesAllowed = 5;

	public Text text;

	// Use this for initialization
	void Start () {
		startGame ();
	}
	
	// Update is called once per frame
	void Update (){

	}

	public void GuessLower (){
		max = guess;
		nextGuess ();
	}

	public void GuessHigher(){
		min = guess;
		nextGuess ();
	}

	void startGame (){

		max = 1000;
	 	min = 1;
		nextGuess ();

	}

	void nextGuess (){
		guess = Random.Range (min, max + 1);
		text.text = guess.ToString ();
		maxGuessesAllowed--;
		if(maxGuessesAllowed == 0)
			Application.LoadLevel("Win");
	}
}
