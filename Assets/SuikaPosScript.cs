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
		genSuika.transform.position = sensor.getSuikaPosition ();

	}
}
