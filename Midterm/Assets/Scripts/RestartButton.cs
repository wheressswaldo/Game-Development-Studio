using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {

	public static int progress;

	void Start () {
		progress = 0;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			Application.LoadLevel ( Application.loadedLevel );
		}
	}
}
