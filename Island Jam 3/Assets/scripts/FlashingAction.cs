using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingAction : MonoBehaviour {
	public float flashingTime = 0.1f;

	public Sprite inactiveSprite;
	public Sprite activeSprite;
	public Sprite pressedSprite;
	public KeyCode key;

	float timeout = -1.0f;

	bool active = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Activate () {
		active = true;
		GetComponent<SpriteRenderer> ().sprite = activeSprite;

	}

	public void Deactivate () {
		active = false;
		GetComponent<SpriteRenderer> ().sprite = inactiveSprite;
	}
}
