using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Sprite[] scores;
	public GameObject digit;
	public GameObject canvas;
	
	// references to individual digit transform components
	private RectTransform rect1;
	private RectTransform rect2;
	private RectTransform rect3;

	// references to to idividial digit image components
	private Image spr1;
	private Image spr2;
	private Image spr3;
	
	public static int scoreCount;

	void Start () {
		GameObject first = Instantiate(digit, canvas.transform, false);
		GameObject second = Instantiate(digit, canvas.transform, false);
		GameObject third = Instantiate(digit, canvas.transform, false);
		
		rect1 = first.GetComponent<RectTransform>();
		rect2 = second.GetComponent<RectTransform>();
		rect3 = third.GetComponent<RectTransform>();

		spr1 = first.GetComponent<Image>();
		spr2 = second.GetComponent<Image>();
		spr3 = third.GetComponent<Image>();
		
		rect1.localScale = new Vector3(.5f, .5f, 1);
		rect1.localPosition = new Vector3(0,150,0);	
	}
	
	void Update(){
		activateSprite(spr1);
		spr1.sprite =  scores[scoreCount % 10];
		
		if(scoreCount == 10 || scoreCount == 100){
			repositionSprites();
		} 
		if(scoreCount > 9 && scoreCount < 100){
			activateSprite(spr2);
			spr2.sprite = scores[scoreCount / 10];
		}else if(scoreCount > 99){
			activateSprite(spr3);
			spr3.GetComponent<Image>().sprite = scores[scoreCount / 100];
		}
    }

    private void repositionSprites(){
        if(scoreCount == 10){
            //reposition score count digits
            rect1.localPosition = new Vector3(25, 150, 0);
            rect2.localPosition = new Vector3(-25, 150, 0);
		}else{
            rect1.localPosition = new Vector3(50, 150, 0);
            rect2.localPosition = new Vector3(0, 150, 0);
            rect3.localPosition = new Vector3(-50, 150, 0);
        }
    }

	// Sets back to maximum opacity to simulate visible score
	private void activateSprite(Image im){
		im.color = new Color(1f,1f,1f,1f);
	}
}
