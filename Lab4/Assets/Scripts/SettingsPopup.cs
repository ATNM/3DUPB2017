using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPopup : MonoBehaviour {

	public Slider speedSlider;

	public void Open() {
		gameObject.SetActive(true);
	}

	public void Close() {
		gameObject.SetActive(false);
	}

	public void OnSpeedSliderValueChanged(float speed) {
		//Debug.Log("Speed is " + speed);
		PlayerPrefs.SetFloat("speed", speed);
		Messenger<float>.Broadcast(GameEvent.SPEED_CHANGED, speed);
	}

	public void OnNameChanged(string name) {
		Debug.Log("name is " + name);
	}

	void Start() {
		speedSlider.value = PlayerPrefs.GetFloat("speed", 1);
	}
}
