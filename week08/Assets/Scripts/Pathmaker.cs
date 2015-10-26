using UnityEngine;
using System.Collections;

public class Pathmaker : MonoBehaviour {

	// public counter
	public static int counter = 0;
	public Transform floorPrefab;
	public Transform pathmakerPrefab;
	

	void Start () {
		// Instantiate 2 in the beginning so it's not severely biased against one side
		// This results in a lot of collisions though... slightly "laggy" looking result
		// due to the pathmaker repositioning... hmm
		Instantiate (pathmakerPrefab, transform.position, Quaternion.Euler (transform.eulerAngles.x,
		                                                                	transform.eulerAngles.y + 180f,
		                                                              		transform.eulerAngles.z));
	}

	// Update is called once per frame
	void Update () {
		// check number of tiles created
		if (counter < 100) {
			// round the transform.position to be multiples of 5, it makes everything neat and organized
			transform.position = new Vector3 ( Mathf.Round(transform.position.x/5) * 5,
			                                   Mathf.Round(transform.position.y/5) * 5,
			                                   Mathf.Round (transform.position.z/5) * 5);
			// check if there's a tile already where the pathmaker is
			// if there is, move the pathmaker forward
			// this makes it so that you don't keep creating tiles in the same place...
			if (TilePositions.tilePositions.Contains(transform.position)){
				Debug.Log ("COLLISION AT:" + transform.position.ToString());
				transform.position += transform.TransformDirection (Vector3.forward) * 5f;
			}
			// else continue with the pathmaking
			else{
				// create a random number from 0 to 1
				float random = Random.Range (0.0f, 1.0f);
				// 25% chance to turn +90
				if (random < 0.25f) {
					Debug.Log ("TURN 90");
					transform.eulerAngles = new Vector3 (transform.eulerAngles.x, 
					                                    transform.eulerAngles.y + 90f,
					                                    transform.eulerAngles.z);
				} 
				// 25% chance to turn -90
				else if (random < 0.5f) {
					Debug.Log ("TURN -90");
					transform.eulerAngles = new Vector3 (transform.eulerAngles.x, 
					                                    transform.eulerAngles.y - 90f,
					                                    transform.eulerAngles.z);
				} 
				// 5% chance to go up randomly by 3 to 4
				else if (random < 0.55f) {
					Debug.Log ("GO UP");
					Instantiate (pathmakerPrefab, new Vector3 (transform.position.x,
					                                           transform.position.y + Random.Range (3.0f, 4.0f),
					                                           transform.position.z), transform.rotation);
				} 
				// 5% chance to change the color
				else if (random < 0.60f){
					TilePositions.tileColor = new Color (Random.Range (0.0f, 1.0f),
					                       				 Random.Range (0.0f, 1.0f),
					                      				 Random.Range (0.0f, 1.0f));
				}
				// 5% chance to create another pathmaker at the current location
				// this always triggers a collision, causing the pathmaker to move forward once 
				// (since there's always a tile at that position)
				else if (random > 0.95f) {
					Debug.Log ("COPY");
					Instantiate (pathmakerPrefab, transform.position, transform.rotation);
				}	

				// create a tile
				GameObject tileClone;
				tileClone = Instantiate (floorPrefab, transform.position, Quaternion.Euler(0f, 0f, 0f)) as GameObject;
				// add it to the HashTable, the Vector3 position as the key and the tile as the value
				// we use this to check if there's existing tiles at the position
				TilePositions.tilePositions[transform.position] = tileClone;

				// move the pathmaker forward by 5
				transform.position += transform.TransformDirection (Vector3.forward) * 5f;

				// increase tile counter
				counter++;
			}
		} else {
			// we have enough tiles, start destroying pathmakers
			Destroy(this.gameObject);
		}
	}
}
