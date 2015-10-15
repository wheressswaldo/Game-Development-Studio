using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	public GameObject start;
	public GameObject howtoplay;
	public GameObject instructions;

	public void startGame(){
		Application.LoadLevel (1);
	}

	public void openInstructions(){
		start.SetActive (false);
		howtoplay.SetActive (false);
		instructions.SetActive (true);
	}

	public void closeInstructions(){
		start.SetActive (true);
		howtoplay.SetActive (true);
		instructions.SetActive (false);
	}
}
