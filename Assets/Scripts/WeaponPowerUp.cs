using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPowerUp : MonoBehaviour {

    public PlayerWeaponEnums weaponType;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("PowerUp");
            // AddWeapon
            collision.gameObject.GetComponent<PlayerWeaponManager>().AddWeapon(weaponType);
            //jhlkl
            // Tuhotaan PowerUp
            Destroy(gameObject);
            Debug.Log("Something");
        }
    }
}
