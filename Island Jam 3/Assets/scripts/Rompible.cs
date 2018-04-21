using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rompible : MonoBehaviour {
	private float damage = 0.0f;
	public float damagePerSecond = 5.0f;

	public Text damageLabel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		damage += damagePerSecond * Time.deltaTime;
		damageLabel.text = damage.ToString ("#.00");
	}

	public void ReduceDamage(float damageDelta = 5.0f){
		damage -= damageDelta;
		if (damage < 0.0f) {
			damage = 0.0f;
		}
	}

	public void IncreaseDamage(float damageDelta = 5.0f){
		damage += damageDelta;
		if (damage > 100.0f) {
			Debug.LogError ("Has muerto!");
		}
	}
}
