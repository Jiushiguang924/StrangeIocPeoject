using UnityEngine;
using System.Collections;

public class ScoreServide : IScoreService
{
    public void OnReceiveScore()
    {
        int score=Random .Range(20,100);
    }

    public void RequsetScore(string url)
    {
        Debug.Log("Request score form url:"+url);
		OnReceiveScore();
    }

    public void UpdateScore(string url, int score)
    {
        Debug.Log("Update url"+url);
    }
}
