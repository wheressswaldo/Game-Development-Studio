using UnityEngine;
using System.Collections;

public class WinningScript : MonoBehaviour {

	public GameObject winMessage;
	// whatever code is here: will get fired when something enters the trigger
	// OR, if you put this on the player, it will fire when the player enters a trigger
	void OnTriggerEnter (Collider activator) { // parameter will get automatically filled-in with the activator
		winMessage.SetActive (true);
	}
}