using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfacesExample
{
    public interface ISomeDependency
    {
        void DoSomething();
    }

    public interface ISomeDependency2
    {
        void DoSomething();
    }

    public abstract class SomeDependencyOnScene : MonoBehaviour
    {
        public abstract void DoSomething();
    }
}