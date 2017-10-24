using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenResize : MonoBehaviour {

    Resolution res;

	// Use this for initialization
	void Start () {
        res = Screen.currentResolution;
	}
	
	// Update is called once per frame
	void Update () {
        res = Screen.currentResolution;
	}
}
