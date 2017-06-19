using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreMenu : MonoBehaviour {
	public Text highskorText;

	public void Start(){
		highskorText.text = PlayerPrefs.GetInt ("highscore").ToString();
	}

	public void backToMainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}
}
