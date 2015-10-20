using UnityEngine;
using System.Collections;

public class WinningScript : MonoBehaviour {

	public GameObject winMessage;
	public GameObject closingSign;
	public GameObject stationMarker;
	public Material badMaterial;

	private bool checkedStation;
	private AudioSource source;

	void Start () {
		source = GetComponent<AudioSource> ();
		checkedStation = false;
	}

	// whatever code is here: will get fired when something enters the trigger
	// OR, if you put this on the player, it will fire when the player enters a trigger

	void OnTriggerEnter (Collider activator) { // parameter will get automatically filled-in with the activator
		if (activator.tag == "Player") {
			if (!checkedStation) {
				Debug.Log ("test");
				RestartButton.progress += 1;
				checkedStation = true;
				if (RestartButton.progress >= 2) {
					winMessage.SetActive (true);
				} else {
					if (!source.isPlaying){
						source.Play();
					}
					GetComponent<Renderer> ().material = badMaterial;
					closingSign.SetActive (true);
					stationMarker.SetActive (false);
				}
			}
		}
	}
}