using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorHandler : MonoBehaviour {

    public Button Btn;

    public Color GetColor;
    // Use this for initialization
    void Start () {
		
	}

    public void changeCLr() {
       
        Btn.image.color = Color.red;

    }

    // Update is called once per frame
    void Update () {
        Btn.image.color = Color.red;
    }
}
