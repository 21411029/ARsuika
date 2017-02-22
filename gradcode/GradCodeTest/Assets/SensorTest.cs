using UnityEngine;
using System.Collections;

public class SensorTest : MonoBehaviour {
    public GameObject Sensor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = Sensor.GetComponent<Sensor>().getSuikaPosition();
	}
}
