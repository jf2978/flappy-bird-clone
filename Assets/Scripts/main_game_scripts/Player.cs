using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour {
	// Public variables => Can be accessed via Inspector
	public Vector2 vertical = new Vector2(0,175);
	private AudioSource jumpSound;

	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetButtonDown("Jump")){
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(vertical);
			jumpSound = GetComponent<AudioSource>();
			jumpSound.Play();
		}
		Debug.Log(this.transform.position);
		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		Debug.Log(screenPosition);
		if(screenPosition.y > Screen.height || screenPosition.y < 0){
			die();
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		die();
	}

	void die(){
		Scene s = SceneManager.GetActiveScene();
		SceneManager.LoadScene(s.name);
	}
}
