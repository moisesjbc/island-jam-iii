using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAngry : MonoBehaviour {

	public AngryMeter angryMeter;
	public PlaneGenerator planeGenerator;
	public ThrownAxe axePrefab;

	// Use this for initialization
	void Start () {
		angryMeter.StartMakingAngry();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -10.0f) {
			DestroyPlane ();
		}
	}

	void DestroyPlane (bool usingAxe = false) {
		if (usingAxe) {
			ThrownAxe axe = Instantiate (axePrefab, transform.position, Quaternion.identity) as ThrownAxe;
		}
		Destroy (gameObject);
		angryMeter.StopMakingAngry();
		planeGenerator.GeneratePlane ();
	}

	void OnMouseDown () {
		DestroyPlane (true);
	}
}
