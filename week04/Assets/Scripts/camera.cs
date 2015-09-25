using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Time.fixedTime);
		if (Time.fixedTime < 14.5) {
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (1.5f, 0f, 0f) * Time.deltaTime);
		} else if (Time.fixedTime > 14.5 && Time.fixedTime < 22.5) {
			Camera.main.transform.eulerAngles -= new Vector3 (2f, 0f, 0f) * Time.deltaTime;
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (2f, -2f, 0f) * Time.deltaTime);
		} else if (Time.fixedTime > 22.5 && Time.fixedTime < 31.5) {
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (-3f, -2.5f, 0f) * Time.deltaTime);
		} else if (Time.fixedTime > 31.5 && Time.fixedTime < 35.5) {
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (3f, -2.5f, 0f) * Time.deltaTime);
		} else if (Time.fixedTime > 35.5 && Time.fixedTime < 41) {
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (-3f, -2.5f, 0f) * Time.deltaTime);
		} else if (Time.fixedTime > 41 && Time.fixedTime < 49) {
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (3f, -2f, 0f) * Time.deltaTime);
		} else if (Time.fixedTime > 49 && Time.fixedTime < 52) {
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (0f, -17f, -1.5f) * Time.deltaTime);
		} else if (Time.fixedTime > 52 && Time.fixedTime < 54) {
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (0f, 13f, 0.8f) * Time.deltaTime);
		} else if (Time.fixedTime > 54.5 && Time.fixedTime < 58) {
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (7f, 0f, 0f) * Time.deltaTime);
		} else if (Time.fixedTime > 58 && Time.fixedTime < 64.5) {
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (7f, -3f, 0f) * Time.deltaTime);
		} else if (Time.fixedTime > 64.5 && Time.fixedTime < 80) {
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (0f, -4f, 0f) * Time.deltaTime);
		} else if (Time.fixedTime > 80 && Time.fixedTime < 82) {
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (7f, -14f, 0f) * Time.deltaTime);
		} else if (Time.fixedTime > 82 && Time.fixedTime < 105) {
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (4.7f, -6f, -2f) * Time.deltaTime);
		} else if (Time.fixedTime > 105 && Time.fixedTime < 110) {
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (4f, -5f, 0f) * Time.deltaTime);
		} else if (Time.fixedTime > 110 && Time.fixedTime < 120) {
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (8f, 0f, 0f) * Time.deltaTime);
		} else if (Time.fixedTime > 120 && Time.fixedTime < 125) {
			Camera.main.transform.position = Camera.main.transform.position + (new Vector3 (0f, -5f, -10f) * Time.deltaTime);
		}
	}
}
