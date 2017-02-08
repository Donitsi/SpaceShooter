using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToHighScore : MonoBehaviour {

    public void ToHighScore()
    {
        //Debug.Log("Start");

        StartCoroutine(levelChange());
    }

    IEnumerator levelChange()
    {
        yield return SceneManager.LoadSceneAsync("highScores");
    }
}
