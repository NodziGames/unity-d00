using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	public char letter;

	private float speed = 0.05f;
	// Use this for initialization
	void Start () {
		//this.transform.localPosition = new Vector3 (-1.0f, 2.0f, 0);
		speed += Random.Range(0.00f, 0.05f);
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.localPosition = new Vector3 (this.transform.localPosition.x, this.transform.localPosition.y - speed, 0);

		if (letter == 'A') {
			if (Input.GetKeyDown (KeyCode.A)) {
				float precision = -2.0f - (float)this.transform.localPosition.y;
				Debug.Log ("Precision: " + precision);
				GameObject.Destroy (this.gameObject);
			}
		}

		if (letter == 'S') {
			if (Input.GetKeyDown (KeyCode.S)) {
				float precision = -2.0f - (float)this.transform.localPosition.y;
				Debug.Log ("Precision: " + precision);
				GameObject.Destroy (this.gameObject);
			}
		}

		if (letter == 'D') {
			if (Input.GetKeyDown (KeyCode.D)) {
				float precision = -2.0f - (float)this.transform.localPosition.y;
				Debug.Log ("Precision: " + precision);
				GameObject.Destroy (this.gameObject);
			}
		}

		if (this.transform.localPosition.y < -2.75f) {
			float precision = -2.0f - (float)this.transform.localPosition.y;
			Debug.Log ("Precision: " + precision);
			GameObject.Destroy (this.gameObject);
		}
	}
}
