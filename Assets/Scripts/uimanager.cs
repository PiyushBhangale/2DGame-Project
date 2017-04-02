using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uimanager : MonoBehaviour {
	public Text scoretext;
	public bool gameover = false;
	public int score;
	public Button[] buttons;
	followball fb;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		scoretext.text = "Score :" + score;
		
	}

	public void Updatescore()
	{
		score += 10;
	}

	public void Replay()
	{
		Application.LoadLevel (Application.loadedLevel);
	}
	public void Exit()

	{
		Application.Quit();
	}
	public void Menu()
	{
		Application.LoadLevel ("Menu");
	}

	public void GameOverActivated()
	{
		gameover = true;

		foreach (Button but in buttons) 
			{
				but.gameObject.SetActive (true);
			}
		}
	}

