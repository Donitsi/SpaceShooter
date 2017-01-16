using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour {

    public float moveSpeed = 3;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * moveSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
