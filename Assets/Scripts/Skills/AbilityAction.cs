using UnityEngine;
using System.Collections;

public abstract class AbilityAction : ScriptableObject
{
    public abstract void Action(Unit target);
}
