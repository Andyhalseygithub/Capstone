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
        if (playerpoints == 10)
        {
            GameoverMenucontroller.instance.ShowGamewon();
            won = true;
            //Time.timeScale = 0;
        }
        if (timePassed > 30 && !won)
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
