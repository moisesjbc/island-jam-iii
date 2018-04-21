using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTimeEventSelectable : MonoBehaviour {

	public Rompible rompible;
	public QuickTimeEvent quickTimeEvent;
	private bool selected = false;
	public Camera camera;

	public Sprite selectedSprite;
	public Sprite nonSelectedSprite;


	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer> ().sprite = nonSelectedSprite;
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
				GetComponent<SpriteRenderer> ().sprite = nonSelectedSprite;
			}
		}
	}

	void OnMouseDown() {
		selected = true;
		GetComponent<SpriteRenderer> ().sprite = selectedSprite;
		quickTimeEvent.Activate (rompible);
	}
}
