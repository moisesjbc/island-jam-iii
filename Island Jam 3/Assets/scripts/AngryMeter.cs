﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AngryMeter : MonoBehaviour {

	public float angryValue = 0.0f;
	private float angryDelta = 0.0f;

	// Use this for initialization
	void Start () {
		
	}

	public void StartMakingAngry () {
		angryDelta = 5.0f;
	}

	public void StopMakingAngry () {
		angryDelta = -7.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().name == "main_scene") {
			angryValue += angryDelta * Time.deltaTime;
			if (angryValue < 0.0f) {
				angryValue = 0.0f;
			}
			GetComponent<DamageBar> ().SetValue (angryValue);
		}
	}
}
