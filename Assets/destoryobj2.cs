using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryobj2 : MonoBehaviour {
	public uimanager ui;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col)
	{

		if (col.gameObject.tag == "ball") 
		{

			Destroy (col.gameObject);
			ui.GameOverActivated ();



		}
	}
}
