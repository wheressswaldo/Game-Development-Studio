using UnityEngine;
using System.Collections;

public class MazeMaker : MonoBehaviour {

	public GameObject MazeWall;
	int counter = 0;
	Vector3 random;
	
	// Update is called once per frame
	// good enough...
	void Update () {
		if (counter < 15) {
			float randomNumber = Random.Range (0.0f, 1.0f);
			Debug.Log(randomNumber);
			if (randomNumber < 0.5f){
				GameObject wall = (GameObject)Instantiate (MazeWall, new Vector3 (Random.Range (-26f, 26f), 0.61f, Random.Range (-26f, 26f)), Quaternion.identity);
				wall.transform.localScale = new Vector3( 1.1f, 4.3f, Random.Range (8f, 15f));
				counter++;
			}
			else {
				GameObject wall = (GameObject)Instantiate (MazeWall, new Vector3 (Random.Range (-26f, 26f), 0.61f, Random.Range (-26f, 26f)), Quaternion.Euler(0f,90f,0f));
				wall.transform.localScale = new Vector3( 1.1f, 4.3f, Random.Range (8f, 12f));
				counter++;
			}

		}
	}
}
