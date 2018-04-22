using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTimeEvent : MonoBehaviour {
	public float timeout = 3.0f;
	public float timeoutBetweenEvents = 1.0f;

	public FlashingAction[] actions;
	public KeyCode[] keys;
	public AudioClip[] clips;


	private FlashingAction currentAction = null;
	private KeyCode currentKey;

	public Rompible rompible = null;

	// Use this for initialization
	void Start () {
	}

	void Update () {
		if (currentAction != null) {
			if (Input.GetKeyDown (currentKey)) {
				GetComponent<AudioSource> ().Play ();
				rompible.ReduceDamage (10.0f);
				RestartQuickTimeEvents ();
			} else if (Input.anyKeyDown) {
				GetComponent<AudioSource> ().Play ();
				rompible.IncreaseDamage (5.0f);
				RestartQuickTimeEvents ();
			}
		}
	}


	public void Activate(Rompible rompible) {
		Deactivate ();
		this.rompible = rompible;
		StartCoroutine ("QuickimeEventsCoroutine");
	}

	public void Deactivate() {
		if (currentAction != null) {
			currentAction.Deactivate ();
		}
		StopCoroutine ("QuickimeEventsCoroutine");
	}

	void RestartQuickTimeEvents() {
		Deactivate ();
		Activate (this.rompible);
	}

	IEnumerator QuickimeEventsCoroutine() {
		while (true) {
			int randomIndex = Random.Range (0, 3);
			if (keys [randomIndex] == currentKey) {
				randomIndex = (randomIndex + 1) % 4;
			}
			currentAction = actions [randomIndex];
			currentKey = keys [randomIndex];
			currentAction.Activate ();
			yield return new WaitForSeconds (timeout);
			if (currentAction != null) {
				currentAction.Deactivate ();
				currentAction = null;
			}
		}
	}
}
