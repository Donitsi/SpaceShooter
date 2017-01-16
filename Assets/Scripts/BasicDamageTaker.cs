using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDamageTaker : MonoBehaviour, IDamageAble {

    public int hitPoins = 1;
    public GameObject explosionPrefab;
    private float destroyDelayTime = 0.5f;
    //public float triggerDelayTime = 1;
    public int scoreValue = 100;
    public int playerHealth = 3; 

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
        Destroy(gameObject/*, destroyDelayTime*/);
        GameObject.Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        

        // Pääsy tähän peliobjektiin
        GameObject.Find("GameManager").GetComponent<GameManager>().AddScore(scoreValue);
    }
}
