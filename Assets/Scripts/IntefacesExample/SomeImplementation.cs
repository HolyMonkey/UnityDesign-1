using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfacesExample
{
    public class SomeImplementation : MonoBehaviour, ISomeDependency, ISomeDependency2
    {
        public void DoSomething()
        {
            throw new System.NotImplementedException();
        }

        void ISomeDependency2.DoSomething()
        {
            throw new System.NotImplementedException();
        }
    }
}
