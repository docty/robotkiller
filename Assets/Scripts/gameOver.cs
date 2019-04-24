using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour {

	int score = 0;
	public Text textui;

	// Use this for initialization
	void Start () {
		//get our score from playerprefs
		score = PlayerPrefs.GetInt ("Score");
		//multiply by 10 as we did on displayed score
		score = score * 10;
	}

	public void retry(){
		
			SceneManager.LoadScene (0);
	}

	public void quit(){
		Application.Quit();
	}

}
