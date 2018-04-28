using UnityEngine;
using System.Collections;

public interface IScoreService
{
	void RequsetScore(string url);//请求分数
	void OnReceiveScore();//收到服务器端发来的分数
	void UpdateScore(string url,int score);//跟新分数
}
