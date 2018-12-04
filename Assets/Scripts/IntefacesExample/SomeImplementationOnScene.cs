using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfacesExample
{
    public class SomeImplementationOnScene : SomeDependencyOnScene
    {
        public override void DoSomething()
        {
            Debug.Log("I am doing");
        }
    }
}