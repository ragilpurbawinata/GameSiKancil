using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {
	public Text skorText;
	private bool tampil = false;

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (!tampil) {
			return;
		}
	}

	public void tampilMenuGameOver(int skor){
		gameObject.SetActive (true);
		skorText.text = skor.ToString();
		tampil = true;
		if (PlayerPrefs.GetInt ("highscore") < skor) {
			PlayerPrefs.SetInt ("highscore", skor);
		}
	}

	public void mainLagi(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

	public void backToMainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}
}
