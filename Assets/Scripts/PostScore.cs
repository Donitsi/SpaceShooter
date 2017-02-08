using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


[System.Serializable]
public class HiScore
{
    public string name;
    public int score;
}


[System.Serializable]
public class HiScores
{
    public HiScore[] scores;
}


public class PostScore : MonoBehaviour {


    [SerializeField]
    public InputField usernameInput;

    [SerializeField]
    public Text usernamePref;

    [SerializeField]
    public Text scoreValuePref;

    [SerializeField]
    public Button PostButton;

    [SerializeField]
    public Transform playerScoreList;

    [SerializeField]

    public Transform playerScoreEntryPref;

    int maxPlayer = 10;

    void Start()
    {
        StartCoroutine(GetText());
    }

    IEnumerator GetText()
    {
        UnityWebRequest www = UnityWebRequest.Get("http://localhost:5000/scores");  // https://doni-server.herokuapp.com/scores
        yield return www.Send();

        if (www.isError)
        {
            Debug.Log(www.error);
        }
        else
        {
            // Show results as text
            Debug.Log(www.downloadHandler.text);
            HiScores hs = JsonUtility.FromJson<HiScores>(www.downloadHandler.text);

            Debug.Log(hs.scores.Length);

            foreach (HiScore h in hs.scores)
            {
                Debug.Log("Name: " + h.name);
                Debug.Log("Score: " + h.score);
                Debug.Log(hs.scores.Length);

                Transform clone1 = GameObject.Instantiate(playerScoreEntryPref, playerScoreList);
                clone1.FindChild("Username").GetComponentInChildren<Text>().text = h.name;
                clone1.FindChild("Score").GetComponentInChildren<Text>().text = h.score.ToString();

                //Transform cloneScore = GameObject.Instantiate(playerScoreEntryPref, playerScoreList.position, Quaternion.identity);
                //cloneScore.text = h.score.ToString();
                //usernamePref.text = h.name;
                //scoreValuePref.text = h.score.ToString();
            }

            // Or retrieve results as binary data
            byte[] results = www.downloadHandler.data;
        }
    }

    public void PostHighScore()
    {

        HiScore hs = new HiScore();

        Debug.Log("HighScore posted!");


        hs.name = usernameInput.text;
        hs.score = ScoreManager.score;

        StartCoroutine(POST(hs));

    }

    IEnumerator POST(HiScore hs)
    {
        Dictionary<string, string> headers = new Dictionary<string, string>();
        headers.Add("Content-Type", "application/json"); // Key + Value (Postman -> Post -> Headers )

        string jsonData = JsonUtility.ToJson(hs);
        byte[] postData = System.Text.Encoding.UTF8.GetBytes(jsonData);

        WWW www = new WWW("http://localhost:5000/scores",
                            postData,
                            headers);

        yield return www;

        //Debug.Log(www);
    }
}
