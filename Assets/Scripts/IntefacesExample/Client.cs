using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterfacesExample
{
    public class Client : MonoBehaviour
    {
        [SerializeField] private ISomeDependency _someDependecy;
        [SerializeField] private SomeDependencyOnScene _someDependecyOnScene;
        [SerializeField] private GameObject _dependencyContainer;

        private void OnValidate()
        {
            if(_dependencyContainer.GetComponent<ISomeDependency>() == null)
            {
                Debug.LogError("");
                _dependencyContainer = null;
            }
            if (_dependencyContainer.GetComponent<ISomeDependency2>() == null)
            {
                Debug.LogError("");
                _dependencyContainer = null;
            }
        }
    }
}
