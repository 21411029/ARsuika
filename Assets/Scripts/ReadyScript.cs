using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReadyScript : MonoBehaviour {

	// Use this for initialization
	public Text text;

	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		text = GetComponentInChildren<Text> ();

		if (Time.timeSinceLevelLoad >= 1.0f && Time.timeSinceLevelLoad < 2.0f) {
			text.text = "2";
		}
		if (Time.timeSinceLevelLoad >= 2.0f && Time.timeSinceLevelLoad < 3.0f) { 
			text.text = "1";
		}
		if (Time.timeSinceLevelLoad >= 3.0f && Time.timeSinceLevelLoad < 4.0f) {
			text.text = "start";
		}
		if (Time.timeSinceLevelLoad >= 4.0f) {
			SceneManager.LoadScene ("GetKinect", LoadSceneMode.Single);
			SceneManager.LoadScene ("suikawari", LoadSceneMode.Additive);
		}
	}
}
