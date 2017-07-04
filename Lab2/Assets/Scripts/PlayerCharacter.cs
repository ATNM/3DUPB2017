﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

	private int _health;

	void Start () {
		_health = 5;
	}

	public void Hurt(int damage) {
		_health -= damage;
		if (_health < 0) {
			Debug.Log ("Ai murit fraiere");
		}
	}
}
