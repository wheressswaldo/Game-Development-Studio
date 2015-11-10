using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {
	public AudioClip catAlert;
	public AudioClip dead;

	void FixedUpdate(){
		foreach (GameObject mouse in GameManager.mouseList) {
			Vector3 directionToMouse = mouse.transform.position - transform.position;
			float angle = Vector3.Angle (transform.forward, directionToMouse);

			if (angle < 90f) {
				Ray catRay = new Ray (transform.position, directionToMouse);
				RaycastHit catRayHitInfo = new RaycastHit ();
				if (Physics.Raycast (catRay, out catRayHitInfo, 100f)) {
					if (catRayHitInfo.collider.tag == "Mouse") {
						if (catRayHitInfo.distance < 4f) {
							if (!GetComponent<AudioSource>().isPlaying){
								GetComponent<AudioSource>().clip = dead;
								GetComponent<AudioSource>().Play ();
							}
							Destroy (mouse.gameObject);
						} else {
							if (catRayHitInfo.distance < 15f) {
								if (!GetComponent<AudioSource>().isPlaying){
									GetComponent<AudioSource>().clip = catAlert;
									GetComponent<AudioSource>().Play ();
								}
								GetComponent<Rigidbody> ().AddForce (directionToMouse.normalized * 1000f);
							}
						}
					}
				}
			}
		}
	}

	void OnDestroy(){
		GameManager.catList.Remove (this.gameObject);
	}
}
