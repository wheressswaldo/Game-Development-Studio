using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	public void RestartGame() {
		Application.LoadLevel ( 0 );
	}
}
