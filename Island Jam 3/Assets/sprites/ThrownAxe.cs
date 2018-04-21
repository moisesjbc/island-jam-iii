using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrownAxe : MonoBehaviour {

	public float timeout = 3.0f;
	public bool active = true;

	public void Activate (bool right = true) {
		active = true;
	}

	void Update() {
		if (active) {
			timeout -= Time.deltaTime;
			if (timeout < 0.0f) {
				Destroy (gameObject);
			}
		}
	}
}
