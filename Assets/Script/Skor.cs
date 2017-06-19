using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour {
	public Text skorText;
	private int skor = 0;
	public AudioClip skorClip;
	AudioSource skorAudio;

	// Use this for initialization
	void Start () {
		skorAudio = GetComponent<AudioSource> ();
		updateSkor ();
	}

	void updateSkor () {
		skorText.text = skor.ToString();
	}

	public void addSkor(){
		skor++;
		updateSkor ();
		skorAudio.clip = skorClip;
		skorAudio.Play ();
	}

	public int getSkor(){
		return skor;
	}
}
