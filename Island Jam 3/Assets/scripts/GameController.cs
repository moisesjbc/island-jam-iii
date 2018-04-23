using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {	
	private MusicController musicController;
	float intensity = 0.0f;

	void Start () {
		if (GameObject.Find ("MusicController") != null) {
			musicController = GameObject.Find("MusicController").GetComponent<MusicController>();
		}
	}

	public void GameOver(){
		SceneManager.LoadScene("game_over_scene");
	}

	public Rompible rompible1;
	public Rompible rompible2;
	public Rompible rompible3;
	public AngryMeter angryMeter;

	void Update () {
		if (musicController != null && SceneManager.GetActiveScene ().name == "main_scene") {
			float d1 = rompible1.damage;
			float d2 = rompible2.damage;
			float d3 = rompible3.damage;
			float a = angryMeter.angryValue;
			intensity += Time.deltaTime * 2.5f;
			musicController.SetIntensity(intensity);
		}
	}
}
