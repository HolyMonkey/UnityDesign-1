using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private IShootable _gun;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _gun.Shoot(transform.position, transform.forward);
        }
    }
}

interface IShootable
{
    void Shoot(Vector3 position, Vector3 direction);
}
