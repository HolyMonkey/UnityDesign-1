using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class AbillityPlaceLogic : ScriptableObject
{
    public abstract IEnumerable<Unit> TryPlace(Vector2 screenPoint);
}
