using UnityEngine;
using UnityEngine.UI;

public class RegisterButton : MonoBehaviour {

    public Button RegisBtn;
    
    
	// Update is called once per frame
	void Update () {

        /* Checking the status for the password that user entered and username
         * if both satisfy the requirement the RegisBtn (signup button) will
         * interactable for user.
         */
        if (PasswordValidity.getPasswordInputStatus() == true && UsernameValidity.UserNameStatus == true)
            RegisBtn.interactable = true;
        else {
            RegisBtn.interactable = false;
        }

    }
}
