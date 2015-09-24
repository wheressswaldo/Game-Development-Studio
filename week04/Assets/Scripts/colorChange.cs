using UnityEngine;
using System.Collections;

public class colorChange : MonoBehaviour {
	void OnCollisionEnter(Collision collider) {
		if ( collider.gameObject.CompareTag("Trigger") ){
			transform.GetComponent<Renderer>().material.color = new Color( Random.value, Random.value, Random.value, 1.0f );
		}
	}
}
