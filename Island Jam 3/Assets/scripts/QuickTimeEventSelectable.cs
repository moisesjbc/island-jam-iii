using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTimeEventSelectable : MonoBehaviour {

	public Rompible rompible;
	public QuickTimeEvent quickTimeEvent;
	private bool selected = false;
	public Camera camera;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (selected && Input.GetMouseButtonDown(0)) {
			Vector3 mousePosition = this.camera.ScreenToWorldPoint (Input.mousePosition);
			Bounds bounds = GetComponent<SpriteRenderer> ().bounds;
			mousePosition.z = bounds.center.z;

			Debug.Log (mousePosition);
			Debug.Log (bounds);

			if (!bounds.Contains (mousePosition)) {
				selected = false;
				GetComponent<SpriteRenderer> ().color = Color.white;
			}
		}
	}

	void OnMouseDown() {
		selected = true;
		GetComponent<SpriteRenderer> ().color = Color.cyan;
		quickTimeEvent.Activate (rompible);
	}
}
