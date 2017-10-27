using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class LeaderBoard : MonoBehaviour {


    public Text RankText;
    public Text NameText;
    public Text PointText;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Checking Table 2");





        /*
         * For SQL Developer: This is for testing u can replace the file reader with your database functions.
         Following code will read from a file and pupulate the leaderboard with name, ranks and points.
         */

        try
        {
            StreamReader streamReader = new StreamReader("Assets\\Scripts\\FakeLeaderBoardInfo.txt");
            string Rank = " " , Name = " ", Points = " ";
            while (Rank != null && Name != null )
            {
                Rank = streamReader.ReadLine();
                Name = streamReader.ReadLine();
                Points = streamReader.ReadLine();

                RankText.text = RankText.text + "\n" + Rank;
                NameText.text = NameText.text + "\n" + Name;
                PointText.text = PointText.text + "\n" + Points;

            }

        }
        catch (Exception e)
        {
            Debug.Log(e);

        }




    }

    // Update is called once per frame
    void Update () {
		
	}
}
