using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour {

	public float speed = 3.0f;
	public float obstacleRange = 3.0f;
	public GameObject fireballPrefab;
	public bool alive {get; private set; }

	private GameObject _fireball;

	void Awake() {
		Messenger<float>.AddListener(GameEvent.SPEED_CHANGED, onSpeedChanged);
	}

	void OnDestroy() {
		Messenger<float>.RemoveListener(GameEvent.SPEED_CHANGED, onSpeedChanged);
	}

	void Start () {
		alive = true;
	}
	
	void Update () {
		if (alive) {
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
					if (_fireball == null) {
						_fireball = Instantiate(fireballPrefab) as GameObject;
						_fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
						_fireball.transform.rotation = transform.rotation;
					}
				}
				else if(hit.distance < obstacleRange) {
					float angle = Random.Range(-100, 100);
					transform.Rotate(0, angle, 0);
				}
			}
		}
	}

	public void Unalive() {
		alive = false;
	}

	private void onSpeedChanged(float speed) {
		this.speed = speed;
	}
}
