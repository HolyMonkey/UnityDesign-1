using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ItemUI : MonoBehaviour
{
    public Image Icon;

    private Item _item;

    [Inject]
    public void Construct(Item item)
    {
        _item = item;
    }

    public void OnClick()
    {
        Debug.Log(_item.Name);
    }

    private void Awake()
    {
        Icon.sprite = _item.Icon;
    }

    public class Factory : PlaceholderFactory<Item, ItemUI>
    {

    }
}
