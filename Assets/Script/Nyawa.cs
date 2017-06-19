using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nyawa : MonoBehaviour {
	public Text nyawaText;
	private int nyawa = 3;
	public AudioClip nyawaClip;
	AudioSource nyawaAudio;

	// Use this for initialization
	void Start () {
		nyawaAudio = GetComponent<AudioSource> ();
		updateNyawa ();
	}

	void updateNyawa () {
		nyawaText.text = nyawa.ToString();
	}

	public void kurangiNyawa(){
		nyawa--;
		updateNyawa ();
		nyawaAudio.clip = nyawaClip;
		nyawaAudio.Play ();
	}

	public int getNyawa(){
		return nyawa;
	}
}
