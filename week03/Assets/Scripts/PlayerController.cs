using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// controls the player movementspeed
	public float movespeed;
	// helps calculate when floating forcefactor is needed
	public float floatingHeight;
	// helps calculating how fast the object is slowed down when it hits the water
	public float dampeningFactor;
	
	void FixedUpdate () {
		// buoyancy effect by adding a force to your object depending on how high it is above the water level
		// when it is exactly at the water level, the force is = to gravity 
		// above a certain height, the object shouldn't get any effects from the water

		// calculate a force factor according to position, we're assuming that the waterlevel is 0 here
		// bounceHeight is set to 1, so forceFactor will only be valid when it's near the water
		float forceFactor = 1f - ((transform.position.y) / floatingHeight);
		
		if (forceFactor > 0f) {
			// apply a lift force to the ball when the ball hits the water
			// this'll simulate a slight floating animation
			// tweak bounceDamp to affect how the ball gets slowed down
			Vector3 lift = -Physics.gravity * (forceFactor - GetComponent<Rigidbody>().velocity.y * dampeningFactor);
			Debug.Log (lift);
			GetComponent<Rigidbody>().AddForceAtPosition(lift, transform.position);
		}

	}

	// Update is called once per frame
	void Update () {

		// W will move the ball forward
		if ( Input.GetKey ( KeyCode.W ) ){
			transform.position += new Vector3( 0f, 0f, movespeed ) * Time.deltaTime;
			//transform.eulerAngles = new Vector3( , , );
		}
		// S will move the ball backwards
		if ( Input.GetKey ( KeyCode.S ) ){
			transform.position += new Vector3( 0f, 0f, -movespeed ) * Time.deltaTime;
		}

		// A will move the ball left
		if ( Input.GetKey ( KeyCode.A ) ){
			transform.position += new Vector3( -movespeed, 0f, 0f ) * Time.deltaTime;
		}

		// D will move the ball right
		if ( Input.GetKey ( KeyCode.D ) ){
			transform.position += new Vector3( movespeed, 0f, 0f ) * Time.deltaTime;
		}

		Camera.main.transform.position = transform.position + new Vector3( 0f, 20f, 0f);

	}
}
