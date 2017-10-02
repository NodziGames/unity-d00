using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour {

	public Ball ball;
	// Use this for initialization

	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (ball.getVSpeed () == 0)
			this.transform.position = new Vector3 (ball.transform.position.x  - 0.25f, ball.transform.position.y - (ball.getPower() * 2), 0);
	}
}