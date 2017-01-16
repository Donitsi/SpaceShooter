using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleWeapon : IWeapon {

    //tallennetaan sisäiseen olioon konstruktorin parametrista
    private GameObject projectilePrefab;

    // konstruktoriin prefab mitä olio tulee käyttämään
    public SimpleWeapon(GameObject projectile)
    {
        projectilePrefab = projectile;
    }

    public void Fire(Vector2 position)
    {
        GameObject.Instantiate(projectilePrefab, position, Quaternion.identity);
    }
}
