using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class StopCircuit : MonoBehaviour {

    public WaypointProgressTracker waypointTracker;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        waypointTracker.enabled = false;
    }
}
