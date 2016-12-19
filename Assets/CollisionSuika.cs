using UnityEngine;
using System.Collections;

public class CollisionSuika : MonoBehaviour {

	public GameObject suika;
	public GameObject gennkeiSuika;
	public GameObject wareSuika;





	// Use this for initialization
	void Start () {
		suika = GameObject.Find ("Suika");
		gennkeiSuika= GameObject.Find ("gennkei");
		wareSuika = GameObject.Find ("ware");

		wareSuika.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/*void OnCollisionEnter(Collision collision){
		if (collision.gameObject.name == "suika") {
			//suika.SetActive (false);
			suika.GetComponent<MeshRenderer> ().material.color = Color.blue;
			cube.SetActive (true);
		}
	}*/
	void OnTriggerEnter(Collider other){
		//Debug.Log ("Hit!");
		if (other.gameObject.tag == "suika") {
			//suika.SetActive (false);
			//suika.GetComponent<MeshRenderer> ().material.color = Color.blue;
			gennkeiSuika.SetActive (false);
			wareSuika.SetActive (true);

		}
	}
}
