using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class followball : MonoBehaviour {
	Vector3 myPos;
	public GameObject myPlay;
	public uimanager ui;
	public moveball mb;
	// Use this for initialization
	void Start () {
		
		myPos=transform.position;
		myPos = myPos + new Vector3(4f,1.9f,0);
	}
	
	// Update is called once per frame

	void Update () 
	{
		if (mb.flag == 0) {
			transform.position = myPlay.transform.position + myPos;
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "coincol") 
		{
			
			Destroy (col.gameObject);
		

		}
	
	}

}

