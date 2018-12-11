using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abillities/New Abillity")]
public class Abillity : ScriptableObject
{
    [SerializeField] private AbillityPlaceLogic _placeLogic;
    [SerializeField] private List<AbilityAction> _actions;

    public AbillityPlaceLogic PlaceLogic => _placeLogic;
    public List<AbilityAction> Actions => _actions;

    public void ApplyActions(IEnumerable<Unit> targets)
    {
        foreach (var action in _actions)
        {
            foreach (var target in targets)
            {
                action.Action(target);
            }
        }
    }
}
