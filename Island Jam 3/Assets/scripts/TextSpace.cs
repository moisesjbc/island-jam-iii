using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSpace : MonoBehaviour {

	[TextArea(3, 10)]
	public string[] texts;
	int currentIndex = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			currentIndex++;
			if (currentIndex < texts.Length) {
				GetComponent<Text> ().text = texts [currentIndex];
			}
		}
	}
}
