using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rintangan : MonoBehaviour {
	private PlayerController playerCon;
	private Nyawa nyawa;

	// Use this for initialization
	void Start () {
		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		if (player != null) {
			playerCon = player.GetComponent<PlayerController>();
			nyawa = player.GetComponent<Nyawa>();
		}
	}

	void OnTriggerEnter(Collider other){
		nyawa.kurangiNyawa ();

		int jumNyawa = nyawa.getNyawa ();
		if (jumNyawa == 0) {
			playerCon.kondisiGame (false);
		}
	}
}
