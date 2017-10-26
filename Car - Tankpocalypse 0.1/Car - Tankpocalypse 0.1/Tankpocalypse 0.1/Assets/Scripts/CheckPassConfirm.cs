using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CheckPassConfirm : MonoBehaviour {

    public InputField userPassword;
    public InputField confirmUserPassword;
    public Image checkBox;
    public Image crossBox;
    private static bool status;


    public void CheckConfirmPass() {

        if (confirmUserPassword.text.Length > 0)
        {

            if (userPassword.text == confirmUserPassword.text)
            {
                checkBox.enabled = true;

                setConfirmPasswordInputStatus(true); 

                if (crossBox.enabled == true)
                {
                    crossBox.enabled = false;
                }

            }
            else
            {

                checkBox.enabled = false;
                crossBox.enabled = true;
                setConfirmPasswordInputStatus(false);
            }

        }
        else {
            crossBox.enabled = false;
            checkBox.enabled = false;
            setConfirmPasswordInputStatus(false);

        }


    }

    // Update is called once per frame
    void Update () {
        CheckConfirmPass();

    }


    /* Checking the status for the password */
    private void setConfirmPasswordInputStatus(bool status)
    {
        CheckPassConfirm.status = status;
    }


    /*This can be used in other classes to check the whether the
     * password the is valid or not. */
    public static bool getConfirmPasswordInputStatus()
    {
        return status;
    }
}
