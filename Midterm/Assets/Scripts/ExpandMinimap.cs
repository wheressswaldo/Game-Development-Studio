using UnityEngine;
using System.Collections;

public class ExpandMinimap : MonoBehaviour {

	public GameObject text;
	public GameObject legend;

	private Camera minimap;
	private bool expanded;

	// Use this for initialization
	void Start () {
		minimap = GetComponent<Camera> ();
		expanded = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.M)) {
			if (expanded) {
				text.SetActive(true);
				expanded = false;
				// literally hacky solution, I don't know how this canvas space works
				legend.transform.position = new Vector3(Screen.width/2, Screen.height/2, 0f);
				minimap.rect = new Rect (0.74f, 0.6f, 0.4f, 0.4f);
			}
			else{
				text.SetActive(false);
				expanded = true;
				// literally hacky solution, I don't know how this canvas space works
				legend.transform.position = new Vector3(Screen.width/200 - 40f, Screen.height/10, 0f);
				minimap.rect = new Rect (0f, 0.05f, 1f, 1f);
			}
		}
	}
}
