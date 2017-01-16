using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDamageTaker : MonoBehaviour, IDamageAble {

    public int hitPoins = 1;
    public GameObject explosionPrefab;
    public float destroyDelayTime = 0.5f;

    public void Damage(int value)
    {
        hitPoins -= value;
        if(hitPoins <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        GameObject.Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject, destroyDelayTime);
    }
}
