using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Gigi : MonoBehaviour {

	PlayableDirector dir;

	// Use this for initialization
	void Start () {
		dir = GetComponent<PlayableDirector>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			dir.Play();
		}
	}
}
