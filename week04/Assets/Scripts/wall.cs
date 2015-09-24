using UnityEngine;
using System.Collections;

public class wall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Color tempColor = transform.GetComponent<Renderer> ().material.color;
		tempColor.a = 0.5f;
		transform.GetComponent<Renderer> ().material.color = tempColor;
	}

}
