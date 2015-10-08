using UnityEngine;
using System.Collections;

public class ChatScript : MonoBehaviour {
	
	public Transform player;
	public GameObject chatBox;
	public GameObject station;
	public GameObject minimapMarker;

	private AudioSource source;

	void Start() {
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && (Vector3.Distance (transform.position, player.position) < 3f)) {
			if (!source.isPlaying){
				source.Play();
			}
			station.SetActive (true);
			chatBox.SetActive (true);
			minimapMarker.SetActive (false);
		}

		if (Vector3.Distance (transform.position, player.position) > 3f) {
			chatBox.SetActive (false);
		}
	}
}
