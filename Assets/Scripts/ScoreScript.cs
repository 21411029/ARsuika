using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	private int score = 0;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText = GameObject.Find("Score").GetComponent<Text> ();
		scoreText.text= "SCORE: " + score.ToString ();

	}
	
	public void ScoreUp (int point)
	{
		score += point;
		//GetComponent<Text>().text = "SCORE: " + score.ToString ();
		scoreText.text= "SCORE: " + score.ToString ();
	}

}
