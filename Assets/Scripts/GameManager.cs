using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    private int score = 0;
    public Text scoreValueObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddScore(int scoreIncrease)
    {
        score += scoreIncrease;
        scoreValueObject.text = score.ToString();
    }
}
