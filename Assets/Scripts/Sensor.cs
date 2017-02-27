using UnityEngine;
using System.Collections;

public class Sensor : MonoBehaviour {

	float timer = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// returns global coord.
	// returns y < 0 if the position is not detected.
	public Vector3 getSuikaPosition (){
		float x, y, z;
		Vector3 result = new Vector3(0,-1,0);

		timer += Time.deltaTime;

		if( timer > 3.0f )
		{
			x = Random.value * 1.5f + 0.5f;
			z = -(Random.value * 1.5f + 0.5f);
			y = 2.0f;
			result = new Vector3 (x,y,z);
			if (timer > 5.0f)
				timer = 0;
		}

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
