using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {

	void FixedUpdate(){
		foreach (GameObject cat in GameManager.catList) {
			Vector3 directionToCat = cat.transform.position - transform.position;
			float angle = Vector3.Angle (transform.forward, directionToCat);
			if (angle < 120f) {
				Ray mouseRay = new Ray (transform.position, directionToCat);
				RaycastHit mouseRayHitInfo = new RaycastHit ();

				if (Physics.Raycast (mouseRay, out mouseRayHitInfo, 100f)) {
					if (mouseRayHitInfo.collider.tag == "Cat") {
						if (mouseRayHitInfo.distance < 15f) {
							if (!GetComponent<AudioSource>().isPlaying){
								GetComponent<AudioSource>().Play ();
							}
							GetComponent<Rigidbody> ().AddForce (-directionToCat.normalized * 1000f);
						}
					}
				}
			}
		}
	}

	void OnDestroy(){
		GameManager.mouseList.Remove (this.gameObject);
	}

}
