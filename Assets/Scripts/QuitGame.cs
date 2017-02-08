using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour {

    public void MainMenu()
    {
        Debug.Log("Start");

        StartCoroutine(MainScreen());
        ScoreManager.score = 0;
    }

    IEnumerator MainScreen()
    {
        yield return SceneManager.LoadSceneAsync("mainMenu");
    }
}
