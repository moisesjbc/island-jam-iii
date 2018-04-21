using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject gameOverPanel = null;

	// Use this for initialization
	void Start () {
		gameOverPanel.SetActive (false);
	}
		
	public void GameOver(){
		SceneManager.LoadScene("game_over_scene");
	}

	public void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
