using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

	// Use this for initialization
	private bool dead = false;
	private float vspd = 6.0f;
	public Pipe pipe;
	public float gravity;
	private int score;
	private float time;

	private bool given = false; //Did it give a point on the pass yet?

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Score
		if (pipe.getXPos () <= this.transform.position.x && !given) {
			given = true;
			score += 5;
		}

		if (pipe.getXPos() == 3.0f) {
			given = false;
		}
		
		vspd -= gravity; //Fall
		this.transform.localPosition = new Vector3 (this.transform.localPosition.x, this.transform.localPosition.y + (vspd * Time.deltaTime), 0);

		if (!dead) {
			//Flap
			if (Input.GetKeyDown (KeyCode.Space)) {
				vspd = 6.0f;
			}
			time += 1 * Time.deltaTime;
		}
		//Dumb Ways To Die
		if (this.transform.position.y <= -2.05f && !dead) {
			dead = true;
			vspd = 3.0f;
			Debug.Log ("Score: " + score);
			Debug.Log ("Time: " + Mathf.RoundToInt(time));
		}

		if (((this.transform.position.y <= -0.5f || this.transform.position.y >= 2.0f) && (pipe.getXPos () < 0.0f && pipe.getXPos () > -2.0f)) && !dead) {
			dead = true;
			vspd = 3.0f;
			Debug.Log ("Score: " + score);
			Debug.Log ("Time: " + Mathf.RoundToInt(time));
		}

		if (dead) {
			this.transform.Rotate (0, 0, 4);
		}
		if (!dead) {
			this.transform.rotation = Quaternion.Euler (0, 0, vspd * 3.0f);
		}
	}

	public bool getDead()
	{
		return (this.dead);
	}
}
