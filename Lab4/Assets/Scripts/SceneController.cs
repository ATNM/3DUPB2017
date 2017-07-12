using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

	public GameObject enemyPrefab;
	private GameObject _enemy;

	void Update () {
		if (_enemy == null) {
			_enemy = Instantiate(enemyPrefab) as GameObject;
			_enemy.transform.position = new Vector3(0, 1, 0);
			float angle = Random.Range(0, 360);
			_enemy.transform.Rotate(Vector3.up, angle);
		}
	}
}
