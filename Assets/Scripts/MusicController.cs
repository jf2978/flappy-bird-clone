using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {
	private static bool alreadyPlayed = false;
	private AudioSource _audio;
	public AudioClip music;

	// Use this for initialization
	void Start () {
		if(!alreadyPlayed){
			_audio = GetComponent<AudioSource>();
			music = _audio.clip;
			_audio.Play();
			alreadyPlayed = true;
		}
		DontDestroyOnLoad(GetComponent<MusicController>());
	}

	public void toggleMusic(){
		// Check if music is already playing...
		if(_audio.isPlaying){
			_audio.Pause();
		}else{
			_audio.Play();
		}
	}
}
