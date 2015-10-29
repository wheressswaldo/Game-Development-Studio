using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {

	public Transform mouse;
	public AudioSource catAlert;
	public AudioSource dead;

	void FixedUpdate(){
		Vector3 directionToMouse = mouse.position - transform.position;
		float angle = Vector3.Angle (transform.forward, directionToMouse);

		if (angle < 90f) {
			Ray catRay = new Ray( transform.position, directionToMouse );
			RaycastHit catRayHitInfo = new RaycastHit();
			if ( Physics.Raycast ( catRay, out catRayHitInfo, 100f ) ){
				if ( catRayHitInfo.collider.tag == "Mouse" ) {
					if (catRayHitInfo.distance < 5f ){
						dead.Play ();
						Destroy(mouse.gameObject);
					}
					else{
						if ( catRayHitInfo.distance < 15f ){
							catAlert.Play();
							GetComponent<Rigidbody>().AddForce(directionToMouse.normalized * 1000f);
						}
					}
				}
			}
		}
	}
}
