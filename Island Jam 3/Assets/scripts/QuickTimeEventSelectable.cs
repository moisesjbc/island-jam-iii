using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTimeEventSelectable : MonoBehaviour {

	public Rompible rompible;
	public QuickTimeEvent quickTimeEvent;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		GetComponent<SpriteRenderer> ().color = Color.cyan;
		quickTimeEvent.Activate (rompible);
	}
}
