using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
	float time = 0.0f;

	void Update () {
		if (SceneManager.GetActiveScene ().name == "main_scene") {
			time += Time.deltaTime;
			int seconds = (int)time % 60;
			int minutes = (int)time / 60;
			GetComponent <Text> ().text = minutes.ToString ("#00") + ":" + seconds.ToString ("#00");
		}
	}

	void OnDestroy () {
		PlayerPrefs.SetString ("time", GetComponent <Text> ().text);
	}
}
