using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rompible : MonoBehaviour {
	public float damage = 0.0f;
	public float damagePerSecond = 5.0f;

	public DamageBar damageBar;

	public GameController gameController;

	enum State {HEALTHY, PREPARING_DISASTER, BREAKING}
	State currentState = State.HEALTHY;
	public float timeToBreak = 0.0f;

	// Use this for initialization
	void Start () {
	}

	void PrepareDisaster () {
		currentState = State.PREPARING_DISASTER;
		timeToBreak = Random.Range (1.0f, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (currentState == State.HEALTHY) {
			PrepareDisaster ();
		} else if (currentState == State.BREAKING) {
			damage += damagePerSecond * Time.deltaTime;
			damageBar.SetValue (damage);
			if (damage > 100.0f) {
				gameController.GameOver ();
			} else if (damage < 0.0f) {
				currentState = State.HEALTHY;
			}
		} else {
			timeToBreak -= Time.deltaTime;
			if (timeToBreak < 0.0f) {
				currentState = State.BREAKING;
			}
		}
	}

	public void ReduceDamage(float damageDelta = 5.0f){
		damage -= damageDelta;
		if (damage < 0.0f) {
			damage = 0.0f;
		}
	}

	public void IncreaseDamage(float damageDelta = 5.0f){
		damage += damageDelta;
	}
}
