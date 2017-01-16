using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {


    public GameObject explosionPrefab;
    private int playerHealth = 3;
    private int enemyHit = 1;
    public Text healthValue;
    private IEnumerator coroutine;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            EnemyHit();
            coroutine = Wating(2.0f);
            StartCoroutine(coroutine);
        }

        if (playerHealth <= 0)
        {
            Death();
        }
    }

    IEnumerator Wating(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
    }

    public void EnemyHit()
    {
        playerHealth -= enemyHit;
        healthValue.text = playerHealth.ToString();
    }

    public void Death()
    {
        Destroy(gameObject/*, destroyDelayTime*/);
        GameObject.Instantiate(explosionPrefab, transform.position, Quaternion.identity);
    }
}
