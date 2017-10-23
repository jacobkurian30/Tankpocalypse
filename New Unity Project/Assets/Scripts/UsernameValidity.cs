using UnityEngine;
using UnityEngine.UI;
public class UsernameValidity : MonoBehaviour {

    public InputField UserName;
    public Image CheckImage;
    public static bool UserNameStatus = false;
    public void UserNameCheck() {

        if (UserName.text.Length > 2)
        {
            CheckImage.enabled = true;
            UserNameStatus = true;
        }

        else
        {
            CheckImage.enabled = false;
            UserNameStatus = false;


        }
    }



}
