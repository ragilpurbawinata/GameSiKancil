using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KonfirmasiKeluar : MonoBehaviour {
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

	public void tampilMenuKonfirmasi(){
		gameObject.SetActive (true);
	}

	public void batal(){
		gameObject.SetActive (false);
	}

	public void keluar(){
		Application.Quit ();
	}
}
