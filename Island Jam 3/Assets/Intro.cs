using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {

	public Sprite[] sprites;
	int currentPage = 0;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			currentPage++;
			Debug.Log ("currentPage: " + currentPage);
			Debug.Log ("sprites length: " + sprites.GetLength(0));
			if (currentPage < sprites.GetLength(0)) {
				GetComponent<Image> ().sprite = sprites [currentPage];
			} else {
				SceneManager.LoadScene ("main_menu_scene");
			}
		}
	}
}
