using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CheckPassConfirm : MonoBehaviour {

    public InputField userPassword;
    public InputField confirmUserPassword;
    public Image checkBox;
    public Image crossBox;

    public void CheckConfirmPass() {

        if (confirmUserPassword.text.Length > 0)
        {

            if (userPassword.text == confirmUserPassword.text)
            {
                checkBox.enabled = true;

                if (crossBox.enabled == true)
                {
                    crossBox.enabled = false;
                }

            }
            else
            {

                checkBox.enabled = false;
                crossBox.enabled = true;
            }

        }
        else {

            crossBox.enabled = false;
            checkBox.enabled = false;
            
        }


    }

    // Update is called once per frame
    void Update () {
        CheckConfirmPass();

    }
}
