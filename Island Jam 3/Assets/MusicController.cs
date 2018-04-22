using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour {

	public AudioClip calmMusicClip;
	public AudioClip intenseMusicClip;
	private AudioSource calmMusic;
	private AudioSource intenseMusic;

	// Use this for initialization
	void Start () {
		calmMusic = gameObject.AddComponent<AudioSource> () as AudioSource;
		intenseMusic = gameObject.AddComponent<AudioSource> () as AudioSource;

		Debug.Log (this.calmMusic);
		Debug.Log (calmMusicClip);
		calmMusic.clip = calmMusicClip;
		intenseMusic.clip = intenseMusicClip;

		calmMusic.loop = true;
		intenseMusic.loop = true;
		DontDestroyOnLoad (this.gameObject);
		calmMusic.Play ();
		intenseMusic.Play ();
		SetIntensity (0.0f);
	}

	public void SetIntensity (float intensity) {
		intensity /= 100.0f;
		calmMusic.volume = 1.0f - intensity;
		intenseMusic.volume = intensity;
	}
}
