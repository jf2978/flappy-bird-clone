using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Auto_Jump : MonoBehaviour {
	bool alive;
	float hRange;
	float vRange;

	void Start(){
		alive = true;
		hRange =  Random.Range(200f,250f);
		vRange =  Random.Range(100f, 150f);
	}

	void FixedUpdate () {
		if(alive){
				InvokeRepeating("jump", 1f, 6f);
		}else {
			Vector2 screenPos = Camera.main.WorldToScreenPoint(bird.transform.position);
			if(screenPos.y < 0){
				Destroy(gameObject);
			}
		}
	}

	void jump(){
		GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		GetComponent<Rigidbody2D>().AddForce(new Vector2(250,150));
	}

	void OnCollisionEnter2D(Collision2D other){
		die();
	}

	void die(){
		CancelInvoke();
		alive = false;
		GetComponent<Animator>().enabled = false;
	}
}
