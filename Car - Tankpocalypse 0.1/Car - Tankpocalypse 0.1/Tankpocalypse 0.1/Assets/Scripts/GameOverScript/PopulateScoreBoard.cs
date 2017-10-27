using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;


public class PopulateScoreBoard : MonoBehaviour {

    public Text NameText;
    public Text RankText;
    public Text ScoreText;
    public Text KillText;

     void Start() {
        string Name = "", Rank = "", Score = "",Kill =""; 
        try
        {
            /*This is a mock funtionaliy for scoreboad. Need to replace with original
             function later.*/
               StreamReader sr = new StreamReader("Assets\\Scripts\\GameOverScript\\FakeScoreBoardInfo.txt");

            while (Name != null) {
                Name = sr.ReadLine();
                Rank = sr.ReadLine();
                Score = sr.ReadLine();
                Kill = sr.ReadLine();

                NameText.text +=  Name +"\n";
                RankText.text += Rank + "\n";
                KillText.text += Kill + "\n"; 
                ScoreText.text +=  Score + "\n"; 

            }
        }
        catch (Exception e) {

            Debug.Log(e);
        }
    }

    
}
