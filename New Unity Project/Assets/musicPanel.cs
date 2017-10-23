using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicPanel : MonoBehaviour {

    public GameObject panel;

    void panelOnOff() {

        panel.gameObject.SetActive(false);
    }

	// Use this for initialization
	void Start () {
        panel.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}



}
