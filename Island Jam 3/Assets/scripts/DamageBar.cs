using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBar : MonoBehaviour {
	public void SetValue (float value) {
		if (value > 100.0f) {
			value = 100.0f;
		} else if (value < 0.0f) {
			value = 0.0f;
		}
		transform.localScale = new Vector3 (value / 100.0f, 1.0f, 1.0f);
	}
}
