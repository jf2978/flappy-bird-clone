using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject bird;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", 1f, 4f);
	}

	// Update is called once per frame
	void Update () {

	}

	void Spawn(){
		Instantiate(bird);
	}
}
