using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Createnemy : MonoBehaviour {
	public GameObject dropobject;
	public float timedelay=10f;
	float time;
	// Use this for initialization
	void Start () {
		time = timedelay;
		
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if (time <= 0) 
		{
			Vector3 objpos = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
			Instantiate (dropobject, objpos, transform.rotation);
			time = timedelay;
		}

		
	}
}
