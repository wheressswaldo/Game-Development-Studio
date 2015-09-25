using UnityEngine;
using System.Collections;

public class motorWorkaround : MonoBehaviour {

	// constraint hacking because reverse motors are broken...
	void OnCollisionEnter(Collision collider) {
		if ( collider.gameObject.CompareTag("Trigger") ){
			transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
		}
	}
}
