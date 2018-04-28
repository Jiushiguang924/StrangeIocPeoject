using UnityEngine;
using System.Collections;

public class ScoreServide : IScoreService
{
    /// <summary>
    /// 收到服务器端发来的分数
    /// </summary>
    public void OnReceiveScore()
    {
        int score=Random .Range(20,100);
    }
    /// <summary>
    /// 请求分数
    /// </summary>
    /// <param name="url"></param>
    public void RequsetScore(string url)
    {
        Debug.Log("Request score form url:"+url);
		OnReceiveScore();
    }
    /// <summary>
    /// 跟新服务端分数
    /// </summary>
    /// <param name="url"></param>
    /// <param name="score"></param>
    public void UpdateScore(string url, int score)
    {
        Debug.Log("Update url"+url);
    }
}
