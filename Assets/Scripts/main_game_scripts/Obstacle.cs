using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
	public Vector2 velocity = new Vector2(-1,0);

	private float range;
	private Rigidbody2D rb;
	

	void Start () {
		rb = GetComponent<Rigidbody2D>();
		range = Random.Range(-.3f,.5f);
		rb.velocity = velocity;
		transform.position = new Vector3(transform.position.x, transform.position.y + range, -1);
	}

	// Update is called once per frame
	void FixedUpdate () {
		if(!Player.alive){
			rb.velocity = Vector2.zero;
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		GetComponent<AudioSource>().Play();
		Score.scoreCount++;
	}
}
