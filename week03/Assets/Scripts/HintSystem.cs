using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HintSystem : MonoBehaviour {

	public Text textUI;
	public Transform player;
	public Transform goal;
	public Transform thing;
	public Transform chest;
	public Transform log;
	

	// Update is called once per frame
	void Update () {
		textUI.text = "";
		if ( (Vector3.Distance(new Vector3(-1.7f, 0f, -85f), player.position) < 40f) ){
			textUI.text = "Welcome to the game, maybe head north and check near that random log ...";
		}
		if ( (Vector3.Distance(log.position, player.position) < 40f) ){
			textUI.text = "Completely off. It's not anywhere near this log..." +
						  "\nCheck the creepy rotating thing.";
		}
		if ( (Vector3.Distance(thing.position, player.position) < 40f) ){
			textUI.text = "Go south from here. Maybe near that random treasure chest???";
		}
		if ( (Vector3.Distance(chest.position, player.position) < 40f) ){
			textUI.text = "It's around here... Maybe it's in that pond over there?";
		}
	}
}
