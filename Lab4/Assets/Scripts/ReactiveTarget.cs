using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(WanderingAI))]
public class ReactiveTarget : MonoBehaviour {

	public void ReactToHit() {
		WanderingAI wand = GetComponent<WanderingAI>();
		if (wand.alive) {
			Messenger.Broadcast(GameEvent.ENEMY_HIT);
		}
		wand.Unalive();
		StartCoroutine(Die());
	}

	private IEnumerator Die() {
		this.transform.Rotate(-75, 0, 0);
		yield return new WaitForSeconds(1.5f);
		Destroy(this.gameObject);
	}
}
