using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class setupLocalPlayer : NetworkBehaviour {

	// Use this for initialization
	void Start () {
        if (isLocalPlayer) {
            GetComponent<drive>().enabled = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
