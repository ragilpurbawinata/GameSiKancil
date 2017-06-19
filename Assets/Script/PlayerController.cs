using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private CharacterController controller;
	private Animator anim;
	private Vector3 moveVector;
	private float speed = 5.0f;
	private float verticalVelocity = 0.0f;
	private float gravity = 12.0f;
	private bool playing = true;
	public GameOverMenu gameOverMenu;
	private Skor skor;

	void Start (){
		controller = GetComponent<CharacterController> ();
		anim = GetComponent<Animator> ();
		skor = GetComponent<Skor> ();
	}

	void Update (){
		if (!playing) {
			anim.SetBool ("Die", true);
			int skorDidapat = skor.getSkor();
			gameOverMenu.tampilMenuGameOver (skorDidapat);
		} else {
			moveVector = Vector3.zero;

			if (controller.isGrounded) {
				verticalVelocity = Input.GetAxis("Fire1") * speed;

				if (verticalVelocity > 0) {
					anim.SetBool ("Jump", true);
				} else {
					anim.SetBool ("Jump", false);
				}

			} else {
				verticalVelocity -= gravity * Time.deltaTime;
			}

			//X
			moveVector.x = Input.acceleration.x * speed;

			//Y
			moveVector.y = verticalVelocity;

			//Z
			moveVector.z = speed;

			controller.Move (moveVector * Time.deltaTime);
		}

	}

	public void kondisiGame(bool status){
		playing = status;
	}
}