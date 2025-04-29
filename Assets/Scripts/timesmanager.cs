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
    [SerializeField]
    private TextMeshProUGUI level;

    public UnityEvent<string, int> submitTimeEvent;

    public void Update()
    {
        inputScore.text = Gamecontroller.CombinedScore.ToString();
    }
    public void SubmitScore()
    {
        submitTimeEvent.Invoke(inputName.text, int.Parse(inputScore.text));
    }
}
