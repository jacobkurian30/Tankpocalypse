using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;


public class PasswordValidity : MonoBehaviour {

    public InputField userPassword;
    private bool passwordValid;
    public Image checkBox;
    public Image crossBox;
    private static bool status;
    bool[] passValidityCheckPoints = new bool[3]; // to hold values for password validity


    /* Check for password validity.
     * Password length should be greater than or equal to 7
     * Password must contain a upper case letter
     * Password must contain a number */

    public void CheckValidity() {
        
        if (userPassword.text != null && userPassword.text.Length >0)
        {
            // checking the length of the password         
            passValidityCheckPoints[0] = userPassword.text.Length >= 7 ? true : false;

            // checking for uppercase letter
            passValidityCheckPoints[1] = (userPassword.text).Any(letter => char.IsUpper(letter));

            // to get the total number of numberic values inserted by user
            Regex regex = new Regex("([0-9])+");

            // checking for numeric values in the user input
            passValidityCheckPoints[2] = regex.IsMatch(userPassword.text) ? true : false; 

            /*checking for all the condition that make a password valid to use. */

            if (passValidityCheckPoints[0] && passValidityCheckPoints[1] && passValidityCheckPoints[2])
            {
                crossBox.enabled = false;
                checkBox.enabled = true;
                setPasswordInputStatus(true);
            }

            else {

                checkBox.enabled = false;
                crossBox.enabled = true;
                setPasswordInputStatus(false);
            }

        }
        else
        {

            checkBox.enabled = false;
            crossBox.enabled = false;
            setPasswordInputStatus(false);

        }

    }


    /* Checking the status for the password */
    private void setPasswordInputStatus(bool status) {
        PasswordValidity.status = status;
    }


    /*This can be used in other classes to check the whether the
     * password the is valid or not. */
    public static bool getPasswordInputStatus() {
        return status;
    }


}
