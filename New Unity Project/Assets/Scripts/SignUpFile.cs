using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SignUpFile : MonoBehaviour {

    // varibales to get the user input
    public InputField userNameInput;
    public InputField passwordInput;
    public InputField passwordConfirmInput;
    public InputField emailInput;

    //Instance variables
    private string userName;
    private string password;
    private string emailAddress;
    private string passwordConfirm;


    // Setter for the variables
    private void setUserName(string userName) {
        this.userName = userName;
    }
    private void setPassword(string password) {
        this.password = password;
    }

    private void setPasswordConfirm(string passwordConfirm) {
        this.passwordConfirm = passwordConfirm;
    }

    private void setEmail(string emailAddress) {
        this.emailAddress = emailAddress;
    }
    //---------------------End of setter methods----------------------


    // getter for the variable
    public string getUserName() {
        return userName;
    }

    public string getPassword() {
        return password;
    }

    public string getPasswordConfirm() {
        return passwordConfirm;
    }

    public string getEmail() {
        return emailAddress;
    }

    // -----------------End of the getter methods------------------------

    /*
     * OnSubmit will be called when user click the Register button.
     * All the setter methods will be executed. And all the variabels
     * will print out to the screen. Will be usable to sent the info.
     * to the database     */
    public void OnSubmit()
    {
        //Calling the setters
        setUserName(userNameInput.text);
        setPassword(passwordInput.text);
        setPasswordConfirm(passwordConfirmInput.text);
        setEmail(emailInput.text);
        

        //printing out the values  for manual testing
        Debug.Log("User Name: " + getUserName() );
        Debug.Log("User Password: " + getPassword());
        Debug.Log("Confirm Pass: " + getPasswordConfirm());
        Debug.Log("User e-mail: " + getEmail());

    }


}
