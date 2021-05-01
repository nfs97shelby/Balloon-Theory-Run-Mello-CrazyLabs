using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numberOfLives : MonoBehaviour
{
	public int lives = 5;
	public Canvas lostScreen;
	public Canvas WinScreen;
	public Canvas HUD;
	AudioSource gameplayMusic;

	void Start() 
	{
		gameplayMusic = GameObject.Find("gameplay_music").GetComponent<AudioSource>();
	}
	
	void Update()
	{
		GetComponent<Text>().text = lives.ToString();

		if (lives == 0) 
		{
			lostScreen.GetComponent<CanvasGroup>().alpha = 1;

			WinScreen.GetComponent<Canvas>().enabled = false;

			HUD.GetComponent<Canvas>().enabled = false;

			gameplayMusic.volume = 0f;
		}

		if (lostScreen.GetComponent<CanvasGroup>().alpha == 1) 
		{
			Time.timeScale = 0f;
		}

		else 
		{
			Time.timeScale = 1f;
		}
	}
}
