using UnityEngine;
using System.Collections;

public class CameraPlayerMovement : MonoBehaviour {

	public float sensitivityX = 5F;
	public float moveSpeed;

	Vector3 moveVector;
	
	void Update(){
		//Look direction
		transform.Rotate (0, Input.GetAxis ("Mouse X") * sensitivityX, 0);

		//Movement direction
		if (Input.GetKey (KeyCode.W)) {
			moveVector = transform.forward * moveSpeed;
		} else if (Input.GetKey (KeyCode.S)) {
			moveVector = -transform.forward * moveSpeed;
		} else if (Input.GetKey (KeyCode.A)) {
			moveVector = -transform.right * moveSpeed;
		} else if (Input.GetKey (KeyCode.D)) {
			moveVector = transform.right * moveSpeed;
		} else {
			moveVector = new Vector3 (0f, 0f, 0f);
		}
	}

	void FixedUpdate () {
		float yVelocity = GetComponent<Rigidbody>().velocity.y;
		GetComponent<Rigidbody>().velocity = moveVector * 5f + Vector3.up * yVelocity;
	}
	
}
