using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float movespeed;

	void FixedUpdate(){
		GetComponent<Rigidbody>().velocity = transform.forward * movespeed;
		Ray moveRay = new Ray (transform.position, transform.forward);

		if (Physics.Raycast(moveRay, 3f)){
			if (Random.Range(0, 1.0f) < 0.5f){
				transform.Rotate(0, 90, 0);
			}
			else {
				transform.Rotate(0, -90, 0);
			}
		}
	}
}
