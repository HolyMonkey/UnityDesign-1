using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Abillities/Place Logics/Single Target")]
public class AbillityPlaceLogicSingleTarget : AbillityPlaceLogic
{
    public override IEnumerable<Unit> TryPlace(Vector2 screenPoint)
    {
        var ray = Camera.main.ScreenPointToRay(new Vector3(screenPoint.x, screenPoint.y, 1));

        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 10))
        {
            if (hit.transform.GetComponent<Unit>())
            {
                return new Unit[] { hit.transform.GetComponent<Unit>() };
            }
        }

        return null;
    }
}
