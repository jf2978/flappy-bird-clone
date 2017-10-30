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
		vRange =  Random.Range(50f,150f);
	}

	void FixedUpdate () {
		Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
		if(alive){
				InvokeRepeating("jump", 1f, 6f);
				if(screenPos.y > Screen.height){
					Destroy(gameObject);
				}
		}else {
			if(screenPos.y < 0){
				Destroy(gameObject);
			}
		}
	}

	void jump(){
		GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		GetComponent<Rigidbody2D>().AddForce(new Vector2(hRange,vRange));
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
