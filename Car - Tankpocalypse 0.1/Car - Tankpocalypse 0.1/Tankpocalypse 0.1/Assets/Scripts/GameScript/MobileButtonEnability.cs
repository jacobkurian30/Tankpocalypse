using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MobileButtonEnability : MonoBehaviour {

    public Button ForwardBtn;
    public Button ReverseBtn;
    public Button RightBtn;
    public Button LeftBtn;

    // Use this for initialization
    void Start()
    {
        // Check unity platform dependent compilation
#if !UNITY_IOS || !UNITY_ANDROID
        Debug.Log("Game Platform Desktop");
        ForwardBtn.gameObject.SetActive(false);
        ReverseBtn.gameObject.SetActive(false);
        RightBtn.gameObject.SetActive(false);
        LeftBtn.gameObject.SetActive(false);


#endif
    }
}
