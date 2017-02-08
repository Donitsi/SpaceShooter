using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public GameObject enemyGameObject;

    public float moveSpeed = 1;
    public float sinAmplitude = 0.1f;
	
	// Update is called once per frame
	void Update () {

        //sinimuotoinen aaltoliike
        transform.Translate(Mathf.Sin(transform.position.y) * sinAmplitude,
                            -moveSpeed * Time.deltaTime,
                            0);

    }
}
