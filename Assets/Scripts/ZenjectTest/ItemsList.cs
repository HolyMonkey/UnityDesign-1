using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ItemsList : MonoBehaviour
{
    private List<Item> _items;
    private ItemUI.Factory _itemFactory;

    [Inject]
    public void Construct(List<Item> items, ItemUI.Factory itemFactory)
    {
        _items = items;
        _itemFactory = itemFactory;
    }

    private void Awake()
    {
        ReDraw();
    }

    private void ReDraw()
    {
        foreach (Transform child in transform)
            Destroy(child.gameObject);

        foreach (var item in _items)
        {
            var itemUi = _itemFactory.Create(item);
            itemUi.gameObject.transform.parent = transform;
        }
    }
}
