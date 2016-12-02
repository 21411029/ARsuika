using UnityEngine;
using System.Collections;

public class CollisionSuika : MonoBehaviour {

	public GameObject suika;
	public GameObject cube;



	// Use this for initialization
	void Start () {
		cube.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(){
		suika.SetActive (false);
		cube.SetActive (true);
	}
}
