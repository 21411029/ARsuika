using UnityEngine;
using System.Collections;

public class SuikaPosScript : MonoBehaviour {
	private Sensor sensor;
	private GameObject genSuika;
	private GameObject recPos;

	// Use this for initialization
	void Start () {
		genSuika = GameObject.Find ("gennkei");
		recPos = GameObject.Find ("ProjectionMarkerReceiver");
		sensor = recPos.GetComponent<Sensor> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 tempSuikaPos = sensor.getSuikaPosition ();
		if (tempSuikaPos.y < 0) {
			return;
		}

		if (tempSuikaPos.y >= 2.0f) {
			genSuika.transform.position = tempSuikaPos;
			genSuika.GetComponent<Rigidbody>().velocity = Vector3.zero;
		}
		Debug.Log(genSuika.transform.position.ToString());
	}
}
