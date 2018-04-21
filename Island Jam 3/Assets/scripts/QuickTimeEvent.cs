using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTimeEvent : MonoBehaviour {
	public float timeout = 3.0f;
	public float timeoutBetweenEvents = 1.0f;

	public FlashingAction[] actions;
	public KeyCode[] keys;

	private FlashingAction currentAction = null;
	private KeyCode currentKey;

	public Rompible rompible = null;

	// Use this for initialization
	void Start () {
		Debug.Log ("actions");
		Debug.Log (actions.Length);
	}

	void Update () {
		if (currentAction != null) {
			if (Input.GetKeyDown (currentKey)) {
				Debug.Log ("Good!");
				rompible.ReduceDamage (10.0f);
				RestartQuickTimeEvents ();
			} else if (Input.anyKeyDown) {
				Debug.Log ("Bad!");
				rompible.IncreaseDamage (5.0f);
				RestartQuickTimeEvents ();
			}
		}
	}


	public void Activate(Rompible rompible) {
		this.rompible = rompible;
		StartCoroutine ("QuickimeEventsCoroutine");
	}

	public void Deactivate() {
		StopCoroutine ("QuickimeEventsCoroutine");
	}

	void RestartQuickTimeEvents() {
		Deactivate ();
		if (currentAction != null) {
			currentAction.Deactivate ();
		}
		Activate (this.rompible);
	}

	IEnumerator QuickimeEventsCoroutine() {
		while (true) {
			yield return new WaitForSeconds (timeoutBetweenEvents);

			int randomIndex = Random.Range (0, 3);
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
