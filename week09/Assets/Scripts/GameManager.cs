using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public static List<GameObject> catList = new List<GameObject>();
	public static List<GameObject> mouseList = new List<GameObject>();

	public GameObject catPrefab;
	public GameObject mousePrefab;

	void Start(){
		GameObject firstCat = (GameObject)Instantiate (catPrefab, new Vector3 (-28f, 1f, 25f), Quaternion.Euler (0f, 180f, 0f));
		GameObject firstMouse = (GameObject)Instantiate (mousePrefab, new Vector3 (28f, 1f, -20f), Quaternion.Euler (0f, 0f, 0f));
		catList.Add (firstCat);
		mouseList.Add (firstMouse);
	}

	void Update(){
		// I can probably make this shorter but #goodenough
		if (Input.GetMouseButtonDown(0)){
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			// generate a "RaycastHit" to remember where the raycast hit
			RaycastHit rayHit = new RaycastHit ();
			
			if (Physics.Raycast (ray, out rayHit)) {
				if (rayHit.collider.tag == "Floor") {
					Debug.Log ("You are putting a cursor over a floor!");
					Debug.DrawRay ( ray.origin, ray.direction * rayHit.distance, Color.red );
					GameObject newCat = (GameObject)Instantiate (catPrefab, new Vector3( rayHit.point.x, 1f, rayHit.point.z), Quaternion.identity);
					catList.Add (newCat);
				}	
			}
		} else if (Input.GetMouseButtonDown(1)){
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			// generate a "RaycastHit" to remember where the raycast hit
			RaycastHit rayHit = new RaycastHit ();
			
			if (Physics.Raycast (ray, out rayHit)) {
				if (rayHit.collider.tag == "Floor") {
					Debug.Log ("You are putting a cursor over a floor!");
					Debug.DrawRay ( ray.origin, ray.direction * rayHit.distance, Color.red );
					GameObject newMouse = (GameObject)Instantiate (mousePrefab, new Vector3( rayHit.point.x, 1f, rayHit.point.z), Quaternion.identity);
					mouseList.Add (newMouse);
				}	
			}
		}
	}
}
