using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms;
using Unity.Services.Leaderboards;
using Unity.Services.Authentication;
using Unity.Services.Core;
using System;

public class Gamecontroller : MonoBehaviour
{
    public static Gamecontroller instance;
    public int playerpoints;
    public TMP_Text PointsText;
    public float timePassed;
    public TMP_Text TimeText;
    public TMP_Text Gameover;
    public bool won;
    public int level;
    public static int uploadlevel;
    public static int timepassedInt;
    public static int CombinedScore;
    public int CombinedScore1;
    public int CombinedScore2;
    public int CombinedScore3;
    public int CombinedScore4;

    public static int Timescore; 



    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int playerpointsInt = Int32.Parse(PointsText.text);
        //print(playerpoints);
        timepassedInt = Mathf.RoundToInt(float.Parse(TimeText.text));

        timePassed += Time.deltaTime;
        TimeText.text = timePassed.ToString();
        PointsText.text = "" + playerpoints.ToString();
        if (level == 1 && playerpoints == 10)
        {
            //print("test" + playerpoints);
            uploadlevel = level;
            Timescore = ((playerpointsInt / timepassedInt) * 100);
            //CombinedScore1 = ((playerpointsInt / timepassedInt) * 10);
            GameoverMenucontroller.instance.ShowGamewon();
            won = true;
            Time.timeScale = 0;
        }
        if (level == 2 && playerpoints == 15)
        {
            uploadlevel = level;
            Timescore = ((playerpointsInt / timepassedInt) * 100);
            //CombinedScore2 = ((playerpointsInt / timepassedInt) * 10);
            GameoverMenucontroller.instance.ShowGamewon();
            won = true;
            Time.timeScale = 0;
        }
        if (level == 3 && playerpoints == 15)
        {
            uploadlevel = level;
            Timescore = ((playerpointsInt / timepassedInt) * 100);
            //CombinedScore3 = ((playerpointsInt / timepassedInt) * 10);
            GameoverMenucontroller.instance.ShowGamewon();
            won = true;
            Time.timeScale = 0;
        }
        if (level == 4 && playerpoints == 15)
        {
            uploadlevel = level;
            Timescore = ((playerpointsInt / timepassedInt) * 100);
            //CombinedScore4 = ((playerpointsInt / timepassedInt) * 10);
            GameoverMenucontroller.instance.ShowGamewon();
            won = true;
            Time.timeScale = 0;
        }
        if (level == 1 && timePassed > 60 && !won)
        {
            //CombinedScore1 = 0;
            Timescore = 0;
            GameoverMenucontroller.instance.ShowGameover1();
            //Time.timeScale = 0;
        }
        if (level == 2 && timePassed > 90 && !won)
        {
            //CombinedScore2 = 0;
            Timescore = 0;
            GameoverMenucontroller.instance.ShowGameover1();
            //Time.timeScale = 0;
        }
        if (level == 3 && timePassed > 120 && !won)
        {
            Timescore = 0;
            //CombinedScore3 = 0;
            GameoverMenucontroller.instance.ShowGameover1();
            //Time.timeScale = 0;
        }
        if (level == 4 && timePassed > 150 && !won)
        {
            Timescore = 0;
            //CombinedScore4 = 0;
            GameoverMenucontroller.instance.ShowGameover1();
            //Time.timeScale = 0;
        }
    }
    public void Addpoints(int pointsAdded)
    {
        playerpoints += pointsAdded;
    }
    void UpdateDisplay()
    {
        PointsText.text = "" + playerpoints.ToString();
    }
}
