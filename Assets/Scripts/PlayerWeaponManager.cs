using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponManager : MonoBehaviour {

    private List<IWeapon> activeWeapons = new List<IWeapon>();

    public GameObject simpleWeaponProjectile;
    public GameObject simpleWeaponProjectile2;
    public AudioSource fireEffect;
    public AudioSource powerUpEffect;


    // Use this for initialization
    void Start () {

        // Luodaan uusi olio, lisätään aseita 
        activeWeapons.Add(new SimpleWeapon(simpleWeaponProjectile));
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            fireEffect.Play();

            foreach (IWeapon w in activeWeapons)
            {
                w.Fire(transform.position);
            }
        }
    }

    public void AddWeapon(PlayerWeaponEnums weaponType)
    {
        Debug.Log("Add new weapon");
        powerUpEffect.Play();
        switch (weaponType)
        {
            case PlayerWeaponEnums.BasicBlaster:
                break;

            case PlayerWeaponEnums.TwinBlaster:
                //activeWeapons.Add(new TwinBlaster(twinPrefab));
                break;

            case PlayerWeaponEnums.VWeapon:
                break;

            default:
                Debug.Log("WeaponType " + weaponType + " not implemented ");
                return;
        }
    }
}
