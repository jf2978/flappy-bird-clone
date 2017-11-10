using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {
	public GameObject pipes;
	
	private float startTime = 1f;
	private float delayTime = 1.5f;

	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateObstacle", startTime, delayTime);
	}
	
	// Update is called once per frame
	void CreateObstacle(){
		if(Player.alive){
			Instantiate(pipes);
		}
	}
}
