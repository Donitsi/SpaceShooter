using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour {

	public void StartGame()
    {
        Debug.Log("Start");

       StartCoroutine(levelChange());
    }

    IEnumerator levelChange()
    {
        yield return SceneManager.LoadSceneAsync("level1");
    }

}
