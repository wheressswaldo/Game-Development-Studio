using UnityEngine;
using System.Collections;

public class colorChange : MonoBehaviour {
	void OnCollisionEnter(Collision other) {
		Debug.Log("Contact was made!");
		if ( other.gameObject.CompareTag("Trigger") ){
			transform.GetComponent<Renderer>().material.color = Color.red;
		}
	}
}
