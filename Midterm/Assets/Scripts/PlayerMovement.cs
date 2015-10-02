using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;
	Rigidbody rbody;
	Vector3 inputVector;

	void Start () {
		rbody = GetComponent<Rigidbody>();
	}
	
	void Update () {
		float jump = Input.GetButtonDown ( "Jump" ) ? 0.2f : 0f;
		inputVector = new Vector3( Input.GetAxis ("Horizontal"), jump, Input.GetAxis ("Vertical") );
		Camera.main.transform.position = transform.position + new Vector3( 0f, 1f, -3f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float yVelocity = rbody.velocity.y;
		rbody.velocity = transform.TransformDirection(inputVector) * moveSpeed;
		rbody.velocity += new Vector3( 0f, yVelocity, 0f);
		
	}
}
