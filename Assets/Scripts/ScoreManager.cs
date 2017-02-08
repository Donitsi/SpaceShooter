using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int score;


    public Text text;


    void Awake()
    {
        text = GetComponent<Text>();
        //score = 0;
        text.text = "Score: " + score.ToString();
    }


    void Update()
    {
    }
}
