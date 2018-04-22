using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {
	public void RestartGame() {
		SceneManager.LoadScene("main_scene");
	}

	public void GoToMenu() {
		SceneManager.LoadScene("main_menu_scene");
	}
}
