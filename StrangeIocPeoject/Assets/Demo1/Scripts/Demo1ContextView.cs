using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
public class Demo1ContextView : ContextView {
	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		this.context=new Demo1Context(this);
	}
}
