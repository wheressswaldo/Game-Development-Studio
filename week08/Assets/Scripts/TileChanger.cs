using UnityEngine;
using System.Collections;

public class TileChanger : MonoBehaviour {
	
	// Use this for initialization of the tile, random color YAY
	// Probably not going to use this though, this looks weird
	void Start () {
		GetComponent<Renderer> ().material.color = TilePositions.tileColor;
	}
}
