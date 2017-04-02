using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveice : MonoBehaviour {
	public GameObject ice;
	Rigidbody2D rb;
	public float delta=1.5f;
	public float speed=2.0f;
	private Vector3 startPos;
	private Vector3 ballpos;
	public GameObject ball;
	bool coll=false;

	void Start () {
		startPos = transform.position;	
		ballpos = ball.transform.position;
	}

	// Update is called once per frame
	void Update () {
		Vector3 v = startPos;
		if (gameObject.tag == "icemovex") {
			v.x += delta * Mathf.Sin (Time.time * speed);
		}
		if (gameObject.tag == "icemovey") {
			v.y += delta * Mathf.Sin (Time.time * speed);
		}

		transform.position = v;
		transform.rotation = Quaternion.identity;


	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "ball")
		{
			col.transform.parent = transform;
		}
}
	void OnCollisionExit2D(Collision2D col)
	{
		if (col.gameObject.tag == "ball")
		{
			col.transform.parent=null;

		}
	}

}
