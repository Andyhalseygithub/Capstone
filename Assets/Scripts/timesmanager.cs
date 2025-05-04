/* using UnityEngine;
using TMPro;

// NOTE: Make sure to include the following namespace wherever you want to access Leaderboard Creator methods
using Dan.Main;
public class LeaderboardManager : MonoBehaviour
{
    [SerializeField] private TMP_Text[] _entryTextObjects;
    [SerializeField] private TMP_InputField _usernameInputField;

// Make changes to this section according to how you're storing the player's score:
// ------------------------------------------------------------
    [SerializeField] private int usertime;
        
    private int Score => Gamecontroller.Timescore;
    // ------------------------------------------------------------

    private void Start()
    {
        LoadEntries();
    }

    private void LoadEntries()
    {
        // Q: How do I reference my own leaderboard?
        // A: Leaderboards.<NameOfTheLeaderboard>
        
        Leaderboards.SkylineLeaderboard.GetEntries(entries =>
        {
            foreach (var t in _entryTextObjects)
                t.text = "";

            var length = Mathf.Min(_entryTextObjects.Length, entries.Length);
            for (int i = 0; i < length; i++)
                _entryTextObjects[i].text = $"{entries[i].Rank}. {entries[i].Username} - {entries[i].Score}";
        });
    }
        
    public void UploadEntry()
    {
        Leaderboards.SkylineLeaderboard.UploadNewEntry(_usernameInputField.text, Score, isSuccessful =>
        {
            if (isSuccessful)
                LoadEntries();
        });
    }
}
*/

using UnityEngine;
using TMPro;
using UnityEngine.Events;
using System.Collections.Generic;

public class timesmanager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI inputScore;
    [SerializeField]
    private TMP_InputField inputName;

    public int timescore;
    

    public UnityEvent<string, int> submitTimeEvent;

    public void Update()
    {
        //inputScore.text = Gamecontroller.CombinedScore.ToString();
        inputScore.text = Gamecontroller.timepassedInt.ToString();
        timescore = int.Parse(inputScore.text);

    }
    public void SubmitScore()
    {
        submitTimeEvent.Invoke("Level " + Gamecontroller.uploadlevel.ToString() + ": " + inputName.text, timescore);
    }
}
