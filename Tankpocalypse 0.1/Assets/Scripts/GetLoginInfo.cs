using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System;


public class GetLoginInfo : MonoBehaviour {

    public InputField userNameText;
    public InputField passwordText;
    public Text InvalidText;


    private string userName;
    private string password;

    //Setter for username
    private void SetUserName(string userName) {
        this.userName = userName;
        
    }

    //Setter for the password
    private void SetPassword(string password) {
        this.password = password;
    }

    //Getter for the username
    public string GetUserName() {
        return userName;
    }

    //Getter for the password
    public string GetPassword() {
        return password;
    }


    //This method just print the username and password 
    public void printInfo() {
        SetPassword(passwordText.text);
        SetUserName(userNameText.text);

        Debug.Log("Username : " + GetUserName());
        Debug.Log("Password: " + GetPassword().ToString());
    }


    public void ChangeScene(string scene)
    {
        bool status = false;
        string strUserName = " ";
        string strPassword = " ";
        try
        {
            StreamReader streamReader = new StreamReader("Assets\\Scripts\\FakeAccountInfo.txt");

            while (strUserName != null && strPassword != null && status != true) {
                strUserName = streamReader.ReadLine();
                strPassword = streamReader.ReadLine();
                if (strUserName == GetUserName() && strPassword == GetPassword()) {
                    status = true;
                }
            }

        }
        catch (Exception e) {


        }
        if (status == true)
        {
            SceneManager.LoadScene(scene);
            
        }
        else
            InvalidText.enabled = true;

    }


}
