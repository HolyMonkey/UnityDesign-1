using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbillitiesExecuter : MonoBehaviour
{
    [SerializeField] private Abillity _currentAbillity;

    public void Execute(Abillity abillity)
    {
        _currentAbillity = abillity;
    }

    private void Update()
    {
        if(_currentAbillity != null)
        {
            var targets = _currentAbillity.PlaceLogic.TryPlace((Vector2)Input.mousePosition);

            if (Input.GetMouseButtonDown(0))
            {
                if(targets != null)
                {
                    _currentAbillity.ApplyActions(targets);
                    _currentAbillity = null;
                }
            }
            else if (Input.GetMouseButtonDown(1))
            {
                _currentAbillity = null;         
            }
        }
    }
}
