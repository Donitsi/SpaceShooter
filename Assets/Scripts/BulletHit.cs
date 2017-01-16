using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour {

    public GameObject explosionPrefab;

    public int damageValue = 1;

	void OnTriggerEnter2D(Collider2D c)
    {
        Debug.Log(c.tag);
        if (c.tag == "Enemy")
        {
            //
            GameObject.Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            //Tuhoaa luodin
            Destroy(gameObject);
            //Destroy(c.gameObject);
            c.gameObject.GetComponent<IDamageAble>().Damage(damageValue);
        }


        //Instantiate(explosionPrefab, transform.position, transform.rotation);
        //Destroy(c.gameObject);
        //Destroy(gameObject);
    }
}
