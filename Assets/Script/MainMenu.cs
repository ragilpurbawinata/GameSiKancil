using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public KonfirmasiKeluar konfirm;
	public GameObject audioOnIcon;
	public GameObject audioOffIcon;

	public void Start(){
		setSoundState ();
	}

	public void toggleAudio(){
		if (PlayerPrefs.GetInt ("Muted", 0) == 0) {
			PlayerPrefs.SetInt ("Muted", 1);
		} else {
			PlayerPrefs.SetInt ("Muted", 0);
		}

		setSoundState ();
	}

	private void setSoundState(){
		if (PlayerPrefs.GetInt ("Muted", 0) == 0) {
			AudioListener.volume = 1;
			audioOnIcon.SetActive(true);
			audioOffIcon.SetActive(false);
		} else {
			AudioListener.volume = 0;
			audioOnIcon.SetActive(false);
			audioOffIcon.SetActive(true);
		}
	}

	public void toGame(){
		SceneManager.LoadScene ("Game");
	}

	public void toHowToPlay(){
		SceneManager.LoadScene ("HowToPlay");
	}

	public void toHighScore(){
		SceneManager.LoadScene ("HighScore");
	}

	public void toAbout(){
		SceneManager.LoadScene ("About");
	}

	public void toKonfirmasiKeluar(){
		konfirm.tampilMenuKonfirmasi ();
	}
}
