using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneGenerator : MonoBehaviour {

	public PlaneAngry planePrefab;
	public AngryMeter angryMeter;
	public ThrownAxe axePrefab;
	public float minY = -2.0f;
	public float maxY = 2.0f;
	public float minTimeout = 1.0f;
	public float maxTimeout = 3.0f;
	public float timeout = 0.0f;
	bool generating = false;

	// Use this for initialization
	void Start () {
		timeout = 0.0f;
	}

	public void GeneratePlane () {
		generating = true;
		timeout = Random.Range (minTimeout, maxTimeout);
	}
	
	// Update is called once per frame
	void Update () {
		if (generating) {
			timeout -= Time.deltaTime;
			if (timeout < -0.0f) {
				Vector3 spawnPosition = transform.position;
				spawnPosition.y = Random.Range (minY, maxY); 
				PlaneAngry plane = Instantiate (planePrefab, spawnPosition, Quaternion.identity) as PlaneAngry;
				plane.planeGenerator = this;
				plane.angryMeter = angryMeter;
				plane.axePrefab = axePrefab;
				timeout = 0.0f;
				generating = false;
			}
		}
	}
}
