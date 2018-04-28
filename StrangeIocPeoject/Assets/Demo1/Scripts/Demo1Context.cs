using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.context.api;
public class Demo1Context : MVCSContext {
    public Demo1Context(MonoBehaviour view):base(view){}

    protected override void mapBindings(){//运行绑定映射
        
        //Command

        //View

        //Model

        //绑定开始事件   创建StartCommand
        commandBinder.Bind(ContextEvent.START).To<StartCommand>().Once();
    }
	
}
