using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepAlive : MonoBehaviour {

	public static KeepAlive instance = null;

	// Use this for initialization
	void Start () {
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
