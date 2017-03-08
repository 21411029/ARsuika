using UnityEngine;
using System.Collections;

public class StickPosScript : MonoBehaviour {

	private Sensor sensor;
	private GameObject stickDevice;
	private GameObject recPos;

	// Use this for initialization
	void Start () {
		stickDevice = GameObject.Find ("stick_device");
		recPos = GameObject.Find ("ProjectionMarkerReceiver");
		sensor = recPos.GetComponent<Sensor> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = sensor.getStickPosition();
		Vector3 front = sensor.getStickFront().normalized;
		float stickLength = GameObject.FindGameObjectWithTag("stick").transform.localScale.z;

		stickDevice.transform.position = pos + front * stickLength / 2 ;
		stickDevice.transform.LookAt (pos + front * stickLength );
	}
}
