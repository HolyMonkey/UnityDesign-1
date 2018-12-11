using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Create New Level")]
public class Level : ScriptableObject
{
    public string Name;
    public int MinLevel;
    public string SceneName;
}
