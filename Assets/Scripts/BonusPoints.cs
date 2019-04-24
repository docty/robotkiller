using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPoints : MonoBehaviour {

	pancam hud;

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player") {
			hud = GameObject.Find ("Main Camera").GetComponent<pancam>();
			hud.increaseScore(10);
			Destroy (this.gameObject);
		}

	}
}
