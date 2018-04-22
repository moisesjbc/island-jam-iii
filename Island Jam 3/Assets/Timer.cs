using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	float time = 0.0f;

	void Update () {
		time += Time.deltaTime;
		int seconds = (int)time % 60;
		int minutes = (int)time / 60;
		GetComponent <Text> ().text = minutes.ToString ("#00") + ":" + seconds.ToString ("#00");
	}
}
