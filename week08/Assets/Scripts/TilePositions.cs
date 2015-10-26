using UnityEngine;
using System.Collections;

public class TilePositions : MonoBehaviour {
	// this is probably better as a singleton but whatever
	public static Hashtable tilePositions = new Hashtable();
	public static Color tileColor;

	void Start() {
		tileColor = new Color (Random.Range (0.0f, 1.0f),
		                       Random.Range (0.0f, 1.0f),
		                       Random.Range (0.0f, 1.0f));
	}
}
