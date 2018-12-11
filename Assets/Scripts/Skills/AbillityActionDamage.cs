using UnityEngine;

[CreateAssetMenu(menuName = "Abillities/Actions/Damage")]
class AbillityActionDamage : AbilityAction
{
    [SerializeField] private int _damageCount;

    public override void Action(Unit target)
    {
        target.ApplyDamage(_damageCount);
    }
}

