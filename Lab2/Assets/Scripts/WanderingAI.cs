using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour {

	public float speed = 3.0f;
	public float obstacleRange = 3.0f;
	private bool _alive;

	void Start () {
		_alive = true;
	}
	
	void Update () {
		if (_alive) {
			transform.Translate(0, 0, speed * Time.deltaTime);
			Ray ray = new Ray(transform.position, transform.forward);
			RaycastHit hit;
			if(Physics.SphereCast(ray, 0.75f, out hit)) {
				// if(hit.distance < obstacleRange) {
				// 	float angle = Random.Range(-100, 100);
				// 	transform.Rotate(0, angle, 0);
				// }

				GameObject hitObject = hit.transform.gameObject;
				if(hitObject.GetComponent<PlayerCharacter>()) {
					// TODO: FIREEEEEEEEEEEEEEEEEEE
				}
				else if(hit.distance < obstacleRange) {
					float angle = Random.Range(-100, 100);
					transform.Rotate(0, angle, 0);
				}
			}
		}
	}

	public void Unalive() {
		_alive = false;
	}
}
