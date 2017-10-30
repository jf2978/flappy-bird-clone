using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public GameObject bird;
	public GameObject canvas;
	public float spawnHeight;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", 1f, 1.5f);
		spawnHeight = Random.Range(20f, 50f);
	}

	void Spawn(){
		GameObject cloneBird = Instantiate(bird, new Vector3(-590, spawnHeight, -1), transform.rotation);
		cloneBird.transform.SetParent(canvas.transform, false);
	}
}
