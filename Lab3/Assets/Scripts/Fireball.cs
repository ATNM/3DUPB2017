using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {

	public float spped = 10.0f;
	public int damage = -1;
	
	void Update () {
		transform.Translate(0, 0, spped * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		PlayerCharacter p = other.GetComponent<PlayerCharacter>();
		if (p != null) {
			p.Hurt(damage);
		}

		Destroy(this.gameObject);
	}
}
