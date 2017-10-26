using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class fuckthis : NetworkBehaviour
{

    // Use this for initialization
    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<drive>().enabled = true;
            Camera.main.transform.position = this.transform.position - this.transform.forward * 10 + this.transform.up * 3;
            Camera.main.transform.LookAt(this.transform);
            Camera.main.transform.parent = this.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
