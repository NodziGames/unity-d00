using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {

	public GameObject obj_a;
	public GameObject obj_s;
	public GameObject obj_d;

	private float timer = 0;
	private int pick;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += 1 * Time.deltaTime;

		if (timer >= 2)
		{
			timer -= 2.0f;
			pick = Random.Range (0, 3);

			if (pick == 0)
				GameObject.Instantiate (obj_a, new Vector3(-1.0f, 2.0f, 0), transform.rotation);
			if (pick == 1)
				GameObject.Instantiate (obj_s, new Vector3(0, 2.0f, 0), transform.rotation);
			if (pick == 2)
				GameObject.Instantiate (obj_d, new Vector3(1.0f, 2.0f, 0), transform.rotation);
		}
	}
}
