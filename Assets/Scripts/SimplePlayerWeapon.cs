using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerWeapon : MonoBehaviour {

    public GameObject projectilePrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject.Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
	}
}
