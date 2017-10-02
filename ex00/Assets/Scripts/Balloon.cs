using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {

	public float size;

	private float breath = 10.0f;
	private float timez = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.localScale = new Vector3 (size, size, 0);
		if (breath <= 10.0f)
			breath += 0.05f;

		size -= 0.01f;

		if (Input.GetKeyDown (KeyCode.Space) && breath >= 1.0f) {
			size += 0.2f;
			breath -= 1.0f;
		}

		timez += 1 * Time.deltaTime;
			

		if (size <= 0 || size >= 2.0f) {
			Debug.Log ("Balloon Life Time: " + Mathf.RoundToInt(timez + 0.05f));
			GameObject.Destroy (this.gameObject);
		}
		
	}
}
