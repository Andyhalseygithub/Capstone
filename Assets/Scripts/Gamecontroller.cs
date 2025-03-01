using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms;

public class Gamecontroller : MonoBehaviour
{
    public static Gamecontroller instance;
    public static int playerpoints;
    public TMP_Text PointsText;
    public float timePassed;
    public TMP_Text TimeText;
    public TMP_Text Gameover;
    public bool won;
    public float level;



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
        timePassed += Time.deltaTime;
        TimeText.text = timePassed.ToString();
        PointsText.text = "" + playerpoints.ToString();
        if (level == 1 && playerpoints == 10)
        {
            GameoverMenucontroller.instance.ShowGamewon();
            won = true;
            //Time.timeScale = 0;
        }
        if (level == 2 && playerpoints == 15)
        {
            GameoverMenucontroller.instance.ShowGamewon();
            won = true;
            //Time.timeScale = 0;
        }
        if (level == 1 && timePassed > 60 && !won)
        {
            GameoverMenucontroller.instance.ShowGameover1();
            //Time.timeScale = 0;
        }
        if (level == 2 && timePassed > 90 && !won)
        {
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
