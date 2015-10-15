using UnityEngine;
using System.Collections;

public class Wander : MonoBehaviour {

	int speed = 3;
	Vector3 wayPoint;
	Vector3 forward;

	// Use this for initialization
	void Start () {
		wander();
	}
	
	// Update is called once per frame
	void Update () {
		// set forward
		forward = transform.TransformDirection (Vector3.forward);

		// check waypoint/raycast
		if ((transform.position - wayPoint).magnitude < 3 || Physics.Raycast(transform.position, forward, 1)) {
			// when the distance between us and the target is less than 3
			// create a new way point target
			wander ();
		}

		// move forward
		transform.position += transform.TransformDirection(Vector3.forward)*speed*Time.deltaTime;
	}

	void wander () {
		// set random waypoint within range
		wayPoint= transform.position + (Random.insideUnitSphere *47);
		wayPoint.y = 1;
		// turn towards waypoint
		transform.LookAt(wayPoint);
	}
}
