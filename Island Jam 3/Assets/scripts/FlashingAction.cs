using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingAction : MonoBehaviour {
	public float flashingTime = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Activate () {
		GetComponent<SpriteRenderer>().color = Color.red;
	}

	public void Deactivate () {
		GetComponent<SpriteRenderer>().color = Color.white;
	}
}
