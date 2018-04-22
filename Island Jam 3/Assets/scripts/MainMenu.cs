using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public void StartGame() {
		SceneManager.LoadScene ("main_scene");
	}

	public void GoToCreditsScene() {
		SceneManager.LoadScene ("credits_scene");
	}

	public void GoToHowToPlayScene() {
		SceneManager.LoadScene ("how_to_play_scene");
	}

	public void ExitGame() {
		Application.Quit ();
	}
}
