using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour {
	// Public variables => Can be accessed via Inspector
	public Vector2 vertical = new Vector2(0,175);
	private AudioSource[] sounds;
	private AudioSource jumpSound;
	private AudioSource dieSound;

	void Start(){
		sounds = GetComponents<AudioSource>();
		jumpSound = sounds[0];
		dieSound = sounds[1];
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump")){
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(vertical);
			jumpSound.Play();
		}
		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if(screenPosition.y > Screen.height || screenPosition.y < 0){
			die();
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		die();
	}

	void die(){
		dieSound.Play();
		GetComponent<Animator>().enabled = false;
		Invoke("restart", .5f);
	}

	void restart(){
		Scene s = SceneManager.GetActiveScene();
		SceneManager.LoadScene(s.name);
	}
}
