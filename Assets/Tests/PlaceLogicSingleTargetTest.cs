using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Linq;

public class PlaceLogicSingleTargetTest {

    [Test]
    public void PlaceLogicSingleTargetTestSelect()
    {
        var target = new GameObject();
        target.AddComponent<BoxCollider>();
        target.AddComponent<Unit>();
        target.GetComponent<BoxCollider>().size = new Vector3(1, 1, 1);
        target.transform.position = new Vector3(0, 0, 0);

        var camera = new GameObject();
        camera.AddComponent<Camera>();
        camera.tag = "MainCamera";
        camera.transform.position = new Vector3(0, 0, -10);

        var placeLogic = ScriptableObject.CreateInstance<AbillityPlaceLogicSingleTarget>();

        var targets = placeLogic.TryPlace(new Vector2(Screen.width / 2, Screen.height / 2));

        Assert.AreEqual(targets.Count(), 1);
        
    }
}
