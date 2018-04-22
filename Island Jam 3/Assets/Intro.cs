using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {

	public Sprite[] sprites;
	int currentPage = 0;

	// Use this for initialization
	void Start () {
		GetComponent<Image> ().sprite = sprites [0];
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			Debug.Log (sprites.Length);
			currentPage++;
			if (currentPage < sprites.Length) {
				GetComponent<Image> ().sprite = sprites [currentPage];
			} else {
				SceneManager.LoadScene ("main_menu_scene");
			}
		}
	}
}
