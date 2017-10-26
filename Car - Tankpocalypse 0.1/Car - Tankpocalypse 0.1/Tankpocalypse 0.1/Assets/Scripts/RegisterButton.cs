using UnityEngine;
using UnityEngine.UI;

public class RegisterButton : MonoBehaviour {

    public Button RegisBtn;
    public InputField EmailAddress;

    
	// Update is called once per frame
	void Update () {

        /* Checking the status for the password that user entered and username
         * if both satisfy the requirement the RegisBtn (signup button) will
         * interactable for user.
         */
        if (CheckPassConfirm.getConfirmPasswordInputStatus() == true && UsernameValidity.UserNameStatus == true && EmailAddress.text.Length > 3
            && PasswordValidity.getPasswordInputStatus() == true)
            RegisBtn.interactable = true;
        else {
            RegisBtn.interactable = false;

  

        }

    }
}
