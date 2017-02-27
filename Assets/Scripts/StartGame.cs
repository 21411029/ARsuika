using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class StartGame : MonoBehaviour {

	// Use this for initialization
	public void sceneLoad () {
		SceneManager.LoadScene ("ready",LoadSceneMode.Single);

	
	}



}
