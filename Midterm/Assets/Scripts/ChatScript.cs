using UnityEngine;
using System.Collections;

public class ChatScript : MonoBehaviour {
	
	public Transform player;
	public GameObject chatBox;
	public GameObject station;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && (Vector3.Distance (transform.position, player.position) < 3f)) {
			station.SetActive (true);
			chatBox.SetActive (true);
		}

		if (Vector3.Distance (transform.position, player.position) > 3f) {
			chatBox.SetActive (false);
		}
	}
}
