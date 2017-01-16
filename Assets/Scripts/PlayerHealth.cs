using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {


    public GameObject explosionPrefab;
    private int playerHealth = 100;
    private int enemyHit = 10;
    public Text healthValue;
    private IEnumerator coroutine;
    public Slider healthSlider;
    //public int currentHealth;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            EnemyHit();
            StartCoroutine(Wating());
        }

        if (playerHealth <= 0)
        {
            Death();
        }
    }

    public IEnumerator Wating(/*float waitTime*/)
    {
        Debug.Log("So far...");
        yield return new WaitForSeconds(2.0f);
        Debug.Log("..so good");
    }


    public void EnemyHit()
    {
        playerHealth -= enemyHit;
        //currentHealth -= enemyHit;
        healthSlider.value -= enemyHit;
        healthValue.text = playerHealth.ToString();
    }

    public void Death()
    {
        Destroy(gameObject/*, destroyDelayTime*/);
        GameObject.Instantiate(explosionPrefab, transform.position, Quaternion.identity);
    }

    public void NoDamage()
    {

    }
}
