using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	// Use this for initialization
	private float vspd = 0.0f;
	public GameObject club;
	private float power = 0.0f;
	private bool charging = false; //Is it charging up the shot?

	private int score = -15;

	void Start () {
	}

	float absolute(float val)
	{
		if (val < 0)
			return (val * -1.0f);
		else
			return (val);
	}
	// Update is called once per frame
	void Update () {
		if (absolute (vspd) != 0) {
			if (vspd > 0)
				vspd -= 0.002f;
			else
				vspd += 0.002f;
		}
		if (absolute (vspd) < 0.004f && vspd != 0) {
			vspd = 0.0f;
			club.transform.position = new Vector3 (this.transform.localPosition.x - 0.25f, this.transform.localPosition.y, 0f);
		}

		if (this.transform.localPosition.y + vspd >= 5.74f || this.transform.localPosition.y + vspd <= -1.74f)
			vspd *= -1;
		
		this.transform.localPosition = new Vector3 (this.transform.localPosition.x, this.transform.localPosition.y + vspd, 0);

		//Controls
		if (Input.GetKey (KeyCode.Space) && vspd == 0)
			charging = true;

		if (charging && power <= 0.4f) {
			power += 0.01f;
		}

		if (!Input.GetKey (KeyCode.Space) && charging) {
			charging = false;
			vspd = power;
			power = 0.0f;
			score += 5;
			Debug.Log ("Score: " + score);
		}


		//Drop in hole
		if (this.transform.position.y > 4.75 && this.transform.position.y < 5.25 && absolute (vspd) < 0.02f) {
			GameObject.Destroy(this.gameObject);
		}
	}

	public float getVSpeed()
	{
		return (this.vspd);
	}

	public float getPower()
	{
		return (this.power);
	}
}
