using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Dan.Main;

public class leaderboards : MonoBehaviour
{
    [SerializeField]
    private List<TextMeshProUGUI> names;
    [SerializeField]
    private List<TextMeshProUGUI> scores;

    private string publicLeaderboardKey = "00ee3cba403204b56df481fd2d978f47b9193182a65c9140b94de4aeabfaf7fa";

    private void Start()
    {
        GetLeaderboard();
    }
    public void GetLeaderboard()
    {
        LeaderboardCreator.GetLeaderboard(publicLeaderboardKey, ((msg) =>
        {
        int looplength = (msg.Length < names.Count) ? msg.Length : names.Count;
        for (int i = 0; i < looplength; i++) {
                names[i].text = msg[i].Username;
                scores[i].text = msg[i].Score.ToString();
            }
        }));
    }

    public void SetLeaderboardEntry(string username, int time)
    {
        print(username + " " + time);
        LeaderboardCreator.UploadNewEntry(publicLeaderboardKey, username, time, ((msg) =>
        {
            GetLeaderboard();
        }));
    }
}
