using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinusoidalMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (-3.0f, Mathf.Sin (Time.time), 0.0f) * Time.deltaTime;
	}
}
