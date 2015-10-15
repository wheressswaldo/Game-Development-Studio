using UnityEngine;
using System.Collections;

public class CameraPlayerMovement : MonoBehaviour {

	public float sensitivityX = 5F;
	public float moveSpeed;
	public float runSpeed;
	public float maxStamina;

	Vector3 moveVector;
	bool isRunning;
	float stamina;

	Rect staminaRect;
	Texture2D staminaTexture;

	void Start(){
		isRunning = false;
		stamina = maxStamina;

		staminaRect = new Rect (Screen.width / 15, Screen.height * 9 / 10, Screen.width / 3, Screen.height / 50);
		staminaTexture = new Texture2D (1, 1);
		staminaTexture.SetPixel (0, 0, Color.white);
		staminaTexture.Apply ();
	}
	
	void Update(){
		//Look direction
		float currentSpeed = moveSpeed;
		transform.Rotate (0, Input.GetAxis ("Mouse X") * sensitivityX, 0);

		if (stamina > 0 && Input.GetKeyDown (KeyCode.LeftShift)) {
			isRunning = true;
		} else if ( Input.GetKeyUp (KeyCode.LeftShift) ){
			isRunning = false;
		}

		if (stamina < 0.01) {
			isRunning = false;
			currentSpeed = moveSpeed;
		}
		
		if (isRunning) {
			stamina -= Time.deltaTime * 2;
			currentSpeed = runSpeed;
			
			if (stamina < 0){
				stamina = 0;
			}
		} else if (stamina < maxStamina){
			stamina += Time.deltaTime * 2;
		}

		moveVector = new Vector3 (0f, 0f, 0f);

		//Movement direction
		if (Input.GetKey (KeyCode.W)) {
			moveVector += transform.forward * currentSpeed;
		}
		if (Input.GetKey (KeyCode.S)) {
			moveVector += -transform.forward * currentSpeed;
		} 

		if (Input.GetKey (KeyCode.A)) {
			moveVector += -transform.right * currentSpeed;
		} 
		if (Input.GetKey (KeyCode.D)) {
			moveVector += transform.right * currentSpeed;
		} 

		Debug.Log (currentSpeed);
	}

	void FixedUpdate () {
		float yVelocity = GetComponent<Rigidbody>().velocity.y;
		GetComponent<Rigidbody>().velocity = moveVector * 5f + Vector3.up * yVelocity;
	}

	void OnGUI(){
		float ratio = stamina / maxStamina;
		float rectWidth = ratio * Screen.width / 3;
		Debug.Log (rectWidth);
		staminaRect.width = rectWidth;
		GUI.DrawTexture (staminaRect, staminaTexture);
	}
	
}
