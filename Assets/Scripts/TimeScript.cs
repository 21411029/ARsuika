using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeScript : MonoBehaviour {

	private float time = 5;
	public CollisionSuika collisionSuika;
	//public GameObject gameOverText;

	// Use this for initialization
	void Start () {

		//gameOverText = GameObject.Find ("GameOver");
		//gameOverText.SetActive (false);
		GetComponent<Text> ().text = ((int)time).ToString ();

	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		/*if (time < 0) {
			StartCoroutine ("GameOver");
		}*/
		if (time < 0) {
			time = 0;
		}
		GetComponent<Text> ().text = ((int)time).ToString ();

		/*IEnumerator GameOver(){
			gameOverText.SetActive(true);
			CollisionSuika.isPlaying = false;
		}*/
	}
}
