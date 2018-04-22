using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsMenu : MonoBehaviour {

	// Use this for initialization
	public void GoToMainMenu () {
		SceneManager.LoadScene ("main_menu_scene");
	}
}
