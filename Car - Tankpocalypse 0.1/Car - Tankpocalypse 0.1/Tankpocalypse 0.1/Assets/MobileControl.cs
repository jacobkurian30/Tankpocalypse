using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileControl : MonoBehaviour {

    public static int TurnAxis = 0;
    public static float Move = 0.0F;

    public static float speed = 10.0F;
    float rotationSpeed = 100.0F;

    // Use this for initialization
    void Start () {
        TurnAxis = 0;
        Move = 0.0F;

    }
    //Left Button Controls
    public void LeftUIPointerUp() {
        TurnAxis = 0;
    }
    public void LeftUIPointerDown() {
        TurnAxis = -1;
    }

    //Right Button Cotrols
    public void RightUIPointerUp()
    {
        TurnAxis = 0;
    }
    public void RightUIPointerDown()
    {
        TurnAxis = 1;
    }

    public void ForwardUP() {
        Move = 0.0F;
    }
    public void ForwardDown()
    {
        Move = 0.5F;
    }
    public void ReverseUP()
    {
        Move = 0.0F;
    }
    public void ReverseDown()
    {
        Move = -0.5F;
    }
}
