using UnityEngine;
using TMPro;
using UnityEngine.Events;
using System.Collections.Generic;

public class timesmanager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI inputScore;
    [SerializeField]
    private TextMeshProUGUI inputName;
    

    public UnityEvent<string, int> submitTimeEvent;

    public void Update()
    {
        //inputScore.text = Gamecontroller.CombinedScore.ToString();
        inputScore.text = Gamecontroller.timepassedInt.ToString();
    }
    public void SubmitScore()
    {
        submitTimeEvent.Invoke("Level " + Gamecontroller.uploadlevel.ToString() + ": " + inputName.text, int.Parse(inputScore.text));
    }
}
