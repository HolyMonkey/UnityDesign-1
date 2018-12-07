using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ProjectInstaller : MonoInstaller
{
    public List<Item> Items;
    public GameObject ItemPrefab;

    public override void InstallBindings()
    {
        Container.BindInstance(Items).AsSingle();
        Container.BindFactory<Item, ItemUI, ItemUI.Factory>().FromComponentInNewPrefab(ItemPrefab);
    }
}
