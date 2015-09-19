using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public Transform player;
	public Text textUI;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Color color = textUI.material.color;
		color.a = 1f;
		textUI.material.color = color;
		if (Input.GetKeyDown(KeyCode.Space) && (Vector3.Distance(transform.position, player.position) < 40f)){
			textUI.text = "YOU WIN";
		}
	
	}
}
