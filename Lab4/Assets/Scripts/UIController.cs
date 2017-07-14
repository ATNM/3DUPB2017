using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	public Text scoreLabel;
	public SettingsPopup settingsPopup;

	private int _score = 0;

	void Awake() {
		Messenger.AddListener(GameEvent.ENEMY_HIT, onEnemyHit);
	}

	void OnDestroy() {
		Messenger.RemoveListener(GameEvent.ENEMY_HIT, onEnemyHit);
	}

	void Start () {
		settingsPopup.Close();
		scoreLabel.text = _score + "";
	}

	public void OnOpenSettings() {
		settingsPopup.Open();
	}

	private void onEnemyHit() {
		_score += 1;
		scoreLabel.text = _score + "";
	}
}
