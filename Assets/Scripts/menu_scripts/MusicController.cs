using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {
	private static bool alreadyPlayed = false;
	private AudioSource _audio;

	// Use this for initialization
	void Start () {
		if(!alreadyPlayed){
			_audio = GetComponent<AudioSource>();
			_audio.Play();
			alreadyPlayed = true;
		}
	}

	public void toggleMusic(){
		// Check if music is already playing...
		Debug.Log("alreadyPlayed?" + alreadyPlayed);
		if(_audio.isPlaying){
			_audio.Pause();
		}else{
			_audio.Play();
		}
	}
}
