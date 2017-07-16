using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		startGame ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			nextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			nextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			startGame();
		}
	}

	void startGame (){

		max = 1000;
	 	min = 1;
	 	guess = 500;

		print("=========================");
		print("Welcome to Number Wizard!");
		print("Pick a number in your head and don't tell me");		

		print("The highest number you can pick is " + max);
		print("The lowest number you can pick is " + min);

		print("Is the number higher or lower than " + guess + " ?");
		print("Up arrow for higher, down for lower, return for equals");

		max += 1;
	}

	void nextGuess (){
		guess = (max + min) / 2;
		print("Higher or lower than " + guess);
		print("Up arrow for higher, down for lower, return for equals");
	}
}
