using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialBook : MonoBehaviour {

	public Sprite [] backgrounds;
	public Button previousPageButton;
	public Button nextPageButton;

	[TextArea(3,10)]
	public string[] texts;
	int currentPage = 0;
	public Text textBox;
	

	// Use this for initialization
	void Start () {
		GetComponent<Image>().sprite = backgrounds[0];
		textBox.text = texts [0];
	}

	public void UpdateButtons (int currentPage) {
		nextPageButton.gameObject.SetActive(currentPage < (backgrounds.Length - 1));
		previousPageButton.gameObject.SetActive (currentPage > 0); 
	}

	public void NextPage () {
		currentPage = currentPage + 1;
		if (currentPage >= backgrounds.Length - 1) {
			currentPage = backgrounds.Length - 1;
		}
		UpdateButtons (currentPage);
		GetComponent<Image>().sprite = backgrounds[currentPage];
		textBox.text = texts [currentPage];
	}

	public void PreviousPage () {
		currentPage = (currentPage - 1);
		if (currentPage <= 0) {
			currentPage = 0;
		}
		UpdateButtons (currentPage);
		GetComponent<Image>().sprite = backgrounds[currentPage];
		textBox.text = texts [currentPage];
	}
	
	// Update is called once per frame
	void Update () {
	}
}
