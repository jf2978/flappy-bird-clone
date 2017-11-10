using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Sprite[] scores;
	public GameObject scoreBox;
	public GameObject canvas;
	
	private Sprite current;

	public static int scoreCount;

	void Start () {
		scoreBox = Instantiate(scoreBox, new Vector3(0, 150, 0), transform.rotation);
		scoreBox.transform.SetParent(canvas.transform, false);
	}
	
	void Update() {
		scoreBox.GetComponent<Image>().sprite = scores[scoreCount % 10];	
	}
}
