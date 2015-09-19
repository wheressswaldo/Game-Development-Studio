using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// controls the player movementspeed
	public float movespeed;
	// controls turn rate
	public float turnRate;

	void Start () {
		GetComponent<Rigidbody>().freezeRotation = true;
	}
	// Update is called once per frame
	void Update () {

		// W will move the ball forward
		if ( Input.GetKey ( KeyCode.W ) ){
			transform.localPosition += transform.forward * movespeed * Time.deltaTime;
			// transform.rotation is BAD AND SCARY
		}
		// S will move the ball backwards
		if ( Input.GetKey ( KeyCode.S ) ){
			transform.localPosition += transform.forward * -movespeed * Time.deltaTime;
		}

		// A will move the ball left
		if ( Input.GetKey ( KeyCode.A ) ){
			transform.eulerAngles += new Vector3( 0f, -turnRate, 0f ) * Time.deltaTime;
			Camera.main.transform.eulerAngles += new Vector3( 0f, -turnRate, 0f ) * Time.deltaTime;
		}

		// D will move the ball right
		if ( Input.GetKey ( KeyCode.D ) ){
			transform.eulerAngles += new Vector3( 0f, turnRate, 0f ) * Time.deltaTime;
			Camera.main.transform.eulerAngles += new Vector3( 0f, turnRate, 0f ) * Time.deltaTime;
		}

		// Q will move camera up
		if ( Input.GetKey ( KeyCode.Q ) ){
			if ( (Camera.main.transform.eulerAngles.x > 0f && Camera.main.transform.eulerAngles.x < 85f) || 
			    (Camera.main.transform.eulerAngles.x > 350f && Camera.main.transform.eulerAngles.x < 360f) ){
				Camera.main.transform.eulerAngles += new Vector3( -turnRate, 0f, 0f ) * Time.deltaTime;
			}
		}
		// E will move camera up
		if ( Input.GetKey ( KeyCode.E ) ){
			if ( (Camera.main.transform.eulerAngles.x > 0f && Camera.main.transform.eulerAngles.x < 45f) ||
			     (Camera.main.transform.eulerAngles.x > 340f && Camera.main.transform.eulerAngles.x < 360f) ){
				Camera.main.transform.eulerAngles += new Vector3( turnRate, 0f, 0f ) * Time.deltaTime;
			}
		}


		Camera.main.transform.position = transform.position + new Vector3( 0f, 10f, 0f);

	}
}
