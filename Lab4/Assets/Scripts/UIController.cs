using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	public Text scoreLabel;
	public SettingsPopup settingsPopup;

	void Start () {
		settingsPopup.Close();
	}
	
	void Update () {
		scoreLabel.text = Time.realtimeSinceStartup.ToString();
	}

	public void OnOpenSettings() {
		settingsPopup.Open();
	}
}
