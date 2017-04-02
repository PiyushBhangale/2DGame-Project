using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour {
	public audiomanager am;
	// Use this for initialization
	void Start () {
		am.Menu.Play ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void onplay()
	{
		Application.LoadLevel ("level1");
	}
}
