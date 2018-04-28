using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

public class StartCommand : Command
{
	/// <summary>
	/// 命令被执行的时候，默认调用Execete方法
	/// </summary>
    public override void Execute()
    {
		Debug.Log("execute");
    }
}
