using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
	public Vector2 velocity = new Vector2(-1,0);
	public float range;
	void Start () {
		range = Random.Range(-.3f,.5f);
		GetComponent<Rigidbody2D>().velocity = velocity;
		transform.position = new Vector3(transform.position.x, transform.position.y + range, -1);
	}

	// Update is called once per frame
	void Update () {

	}
}
