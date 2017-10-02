using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour {

	// Use this for initialization
	private float hspeed = 1.0f;
	public Bird birb;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!birb.getDead ()) {
			this.transform.position = new Vector3 (this.transform.position.x - (hspeed * Time.deltaTime), this.transform.position.y, 0.0f);

			if (this.transform.position.x <= -3)
				this.transform.position = new Vector3 (3.0f, this.transform.position.y, 0.0f);
		}
	}

	public float getXPos()
	{
		return (this.transform.position.x);
	}
}
