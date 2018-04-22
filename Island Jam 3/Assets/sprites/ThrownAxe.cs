using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrownAxe : MonoBehaviour {

	public float timeout = 3.0f;
	public bool active = true;

	public GameObject rightBorder;
	public GameObject leftBorder;

	public Sprite axeCenter;
	public Sprite axeRight;
	public Sprite axeLeft;


	public void Start () {
		rightBorder = GameObject.Find ("RightAxeBorder");
		leftBorder = GameObject.Find ("LeftAxeBorder");

		Debug.Log (transform.position.x);
		Debug.Log (rightBorder.transform.position.x);
		if (transform.position.x > rightBorder.transform.position.x) {
			GetComponent<SpriteRenderer> ().sprite = axeRight;
		} else if (transform.position.x < leftBorder.transform.position.x) {
			GetComponent<SpriteRenderer> ().sprite = axeLeft;
		} else {
			GetComponent<SpriteRenderer> ().sprite = axeCenter;
		}
	}

	void Update() {
		timeout -= Time.deltaTime;
		if (timeout < 0.0f) {
			Destroy (gameObject);
		}
	}
}
