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
		stickDevice.transform.position = sensor.getStickPosition ();
		stickDevice.transform.LookAt (sensor.getStickFront());
	}
}
