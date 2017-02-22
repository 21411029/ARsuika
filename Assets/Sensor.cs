using UnityEngine;
using System.Collections;

public class Sensor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Vector3 getSuikaPosition (){
		Vector3 result = new Vector3 (1, 3, 20);

		return result;
	}

	public Vector3 getStickPosition(){
		Vector3 result = new Vector3(0,0,0);

		return result;
	}

	public Vector3 getStickFront(){
		Vector3 result = new Vector3(0,1,0);

		return result;
	}

}
