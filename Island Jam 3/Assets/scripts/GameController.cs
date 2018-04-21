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
		gameOverPanel.SetActive (true);
		Time.timeScale = 0.0f;
	}

	public void Restart(){
		Time.timeScale = 1.0f;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
