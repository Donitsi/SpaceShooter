using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour {

    public void StartGame()
    {
        Debug.Log("Start");
        ScoreManager.score = 0;

        StartCoroutine(levelChange());
    }

    IEnumerator levelChange()
    {
        yield return SceneManager.LoadSceneAsync("level1");
    }
}
