using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {
	public GameObject pipes;
	public float startTime = .5f;
	public float delayTime = 1f;
	
	public static int score;

	// Use this for initialization
	void Start () {
		score = 0;
		InvokeRepeating("CreateObstacle", startTime, delayTime);
	}
	
	// Update is called once per frame
	void CreateObstacle(){
		if(Player.alive){
			Instantiate(pipes);
		}
	}

	void displayScore(){
		
	}
}
