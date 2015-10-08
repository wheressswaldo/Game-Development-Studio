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
				legend.transform.Translate(700f, 150f, 0f);
				minimap.rect = new Rect (0.74f, 0.6f, 0.4f, 0.4f);
			}
			else{
				text.SetActive(false);
				expanded = true;
				legend.transform.Translate(-700f, -150f, 0f);
				minimap.rect = new Rect (0f, 0.05f, 1f, 1f);
			}
		}
	}
}
