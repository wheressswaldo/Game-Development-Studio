using UnityEngine;
using System.Collections;

public class Creepy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles += new Vector3( 0f, -45f, 0f ) * Time.deltaTime;
	}
}
