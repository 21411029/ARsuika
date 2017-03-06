using UnityEngine;
using System.Collections;
using System;

public class Sensor : MonoBehaviour {

	float timer = 0;
	UDPReceiver recv;

	Vector3 suikaPos, stickPos, stickDir;
	int gameState;

	// Use this for initialization
	void Start () {
		recv = GetComponent<UDPReceiver>();
	}
	
	// Update is called once per frame
	void Update () {
		string rawdata = recv.getLatestUDPPacket();

		string[] data = rawdata.Split(',');
		if (data.Length < 9)
			return;
		if( float.Parse(data[2]) > 0 )
			Debug.Log(rawdata);
		gameState = Int32.Parse(data[0]);
		suikaPos = new Vector3(float.Parse(data[1]), float.Parse(data[2]), float.Parse(data[3]));
		stickPos = new Vector3(float.Parse(data[4]), float.Parse(data[5]), float.Parse(data[6]));
		stickDir = new Vector3(float.Parse(data[7]), float.Parse(data[8]), float.Parse(data[9]));
	}

	// returns global coord.
	// returns y < 0 if the position is not detected.
	public Vector3 getSuikaPosition (){
		return suikaPos;
	}

	public Vector3 getStickPosition(){
		return stickPos;
	}

	public Vector3 getStickFront(){
		return stickDir;
	}


}
