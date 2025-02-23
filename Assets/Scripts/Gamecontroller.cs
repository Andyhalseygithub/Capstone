using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamecontroller : MonoBehaviour
{
    public static Gamecontroller instance;
    public static int playerpoints;
    public TMP_Text PointsText;
    public float timePassed;
    public TMP_Text TimeText;


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
