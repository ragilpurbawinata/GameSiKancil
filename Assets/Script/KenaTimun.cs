using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KenaTimun : MonoBehaviour {
	private Skor skor;

	// Use this for initialization
	void Start () {
		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		if (player != null) {
			skor = player.GetComponent<Skor>();
		}
	}

	void OnTriggerEnter(Collider other){
		Destroy (gameObject);
		skor.addSkor ();
	}
}