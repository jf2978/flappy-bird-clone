using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {
	public GameObject pipes;
	public float startTime = .5f;
	public float delayTime = 1f;

	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateObstacle", startTime, delayTime);
	}
	
	// Update is called once per frame
	void CreateObstacle(){
		GameObject clonePipe = Instantiate(pipes);
	}
}
