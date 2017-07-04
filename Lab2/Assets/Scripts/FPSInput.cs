using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour {
	public float speed = 9.0f;
	public float gravity = -9.8f;

	private CharacterController _charController;

	void Start () {
		_charController = GetComponent<CharacterController>();
	}
	
	void Update () {
		float deltaX = Input.GetAxis("Horizontal") * speed;
		float deltaZ = Input.GetAxis("Vertical") * speed;
		
		// we could move using this, but it would make us go through walls
		// transform.Translate(deltaX * Time.deltaTime, 0, deltaZ * Time.deltaTime);
	  	Vector3 movement = new Vector3(deltaX, 0, deltaZ);
		// we will discuss what this line does on Tuesday
		movement = Vector3.ClampMagnitude(movement, speed);
		movement.y = gravity;
		
		movement *= Time.deltaTime;		
		movement = transform.TransformDirection(movement);
		_charController.Move(movement);
	}
}
