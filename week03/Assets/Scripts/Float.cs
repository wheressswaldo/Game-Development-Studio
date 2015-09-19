using UnityEngine;
using System.Collections;

public class Float : MonoBehaviour {

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
			GetComponent<Rigidbody>().AddForceAtPosition(lift, transform.position);
		}
		
	}
}
