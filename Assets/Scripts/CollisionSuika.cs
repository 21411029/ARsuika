using UnityEngine;
using System.Collections;

public class CollisionSuika : MonoBehaviour {

	//public GameObject suika;
	public GameObject gennkeiSuika;
	public GameObject wareSuika;

	public GameObject scoreText;

	// Use this for initialization
	void Start () {
		//suika = GameObject.Find ("Suika");
		gennkeiSuika= GameObject.Find ("gennkei");
		wareSuika = GameObject.Find ("ware");

		scoreText = GameObject.Find ("Score");

		wareSuika.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){
		//Debug.Log ("Hit!");
/*		if (collision.gameObject.tag == "suika") {
			//suika.SetActive (false);
			//suika.GetComponent<MeshRenderer> ().material.color = Color.blue;
			scoreText.SendMessage("ScoreUp",1);
			gennkeiSuika.SetActive (false);
			wareSuika.SetActive (true);

		}
		*/
	}

}
