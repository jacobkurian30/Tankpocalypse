using System;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class EmailValidity : MonoBehaviour {

    public InputField EmailAddress;
    public Image CheckImage;
    public Image CrossImage;
    

    public void ParseEmailAddress() {
       
        bool valid = false;
        
        char[] delimeter = { '@' };

        /*Splitting the userinput in order to get the email domain*/
        string[] strArray = EmailAddress.text.Split(delimeter);


        /*When length of the strArray is two then which means 
          user have ented a domain name. */
        if (strArray.Length == 2 )
        {
            string parsedDomain = strArray[1];

            try
            {
                //creating a file reader variable
                StreamReader streamReader = new StreamReader("Assets\\Scripts\\free_email_two.txt");
                string domain = "";

                /* Checking the domain that user entered is valid or not, by going through 
                 a list that contains more than 6000 domain names*/
                while (domain != null && valid == false)
                {

                    domain = streamReader.ReadLine();

                    if (parsedDomain == domain)
                    {
                        valid = true;
                    }
                }

            }
            catch (Exception e) {
                Debug.Log(" Error: " + e );
            }

            Debug.Log("Email address status:  " + valid);

            /*If email valid the check sign will appear on the side
             of the email. Else the cross sign will appear*/

            if (valid)
            {
                CheckImage.enabled = true;
                CrossImage.enabled = false;
            }
            else {
                CheckImage.enabled = false;
                CrossImage.enabled = true;
            }

        }
        
    }

    
}
