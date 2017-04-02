using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveball : MonoBehaviour {
	Rigidbody2D rb;
	public float ballspeed;
	public float jump;
	Vector2 position;
	int length;
	public int flag=0;
	public GameObject[] explosion;
	public int explotionno;
	public uimanager ui;
	public followball fb;
	public audiomanager am;
	// Use this for initialization
	void Start () {
		am.background.Play ();
		rb = GetComponent<Rigidbody2D> ();
		
	}

	// Update is called once per frame
	void Update () {
		position = transform.position;
		transform.position=position;

		/*
		float move = Input.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (move*ballspeed, rb.velocity.y);
		*/
	}
		public void Moveright()
	{
		rb.velocity=new Vector2(ballspeed,0);
	}
	public void Moveleft()
	{
		rb.velocity = new Vector2 (-ballspeed, 0);
	}
	public void velocityzero()
	{
		rb.velocity = Vector2.zero;
	}
	public void Jump()
	{
		rb.velocity = new Vector2 (0,jump);
		am.jump.Play ();
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "coincol") 
		{
			Destroy (col.gameObject);
			am.coincollect.Play ();
			ui.Updatescore ();
			 
		}
		if (col.gameObject.tag == "bomb") {
			flag = 1;
			Destroy (gameObject);
			Destroy (col.gameObject);
			while (explotionno != explosion.GetLength(length)) {
				if (col.gameObject.name == "BombLitSprite" + explotionno) {
					explosion [explotionno].gameObject.SetActive (true);
					am.bomb.Play ();
					ui.GameOverActivated ();
					break;
				}
				explotionno++;
			}

		}
			if (col.gameObject.tag == "enemyobj") 
			{

				Destroy (gameObject);
			ui.GameOverActivated ();

			}
		if (col.gameObject.tag == "enemyobj") 
		{

			Destroy (col.gameObject);
			ui.GameOverActivated ();


		}


		}
	}

