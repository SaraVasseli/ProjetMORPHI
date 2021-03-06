﻿using UnityEngine;
using System.Collections;
using System;

public class AnimationPorteEnnemies : MonoBehaviour {


	public Camera monCamera;
	public int nombreEnnemies;


	private Animation monAnimation;
	private AudioSource sonPorte;
	private bool animPlayed;

	// Use this for initialization
	void Start () {
	
		//ouvrePort = false;
		monAnimation = GetComponent<Animation> ();
		sonPorte = GetComponent<AudioSource> ();
		animPlayed = false;
		//nombreEnnemies = 1;


	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (nombreEnnemies);

		if (nombreEnnemies == 0 && !animPlayed) {

			monCamera.depth = 2;
			sonPorte.Play();
			monAnimation.Play ();
			animPlayed = true;
		}
		if (!monAnimation.isPlaying) {

			monCamera.depth = 0;
		}

	}
		
}
