using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {	
	private MusicController musicController;

	void Start () {
		musicController = GameObject.Find("MusicController").GetComponent<MusicController>();
		Debug.Log ("musicController");
		Debug.Log (musicController);
	}

	public void GameOver(){
		SceneManager.LoadScene("game_over_scene");
	}

	public Rompible rompible1;
	public Rompible rompible2;
	public Rompible rompible3;
	public AngryMeter angryMeter;

	void Update () {
		if (SceneManager.GetActiveScene ().name == "main_scene") {
			float d1 = rompible1.damage;
			float d2 = rompible2.damage;
			float d3 = rompible3.damage;
			float a = angryMeter.angryValue;
			musicController.SetIntensity(d1 * 0.25f + d2 * 0.25f + d3 * 0.25f + a * 0.25f);
		}
	}
}
