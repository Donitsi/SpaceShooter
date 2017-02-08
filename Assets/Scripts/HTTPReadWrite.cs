using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


//[System.Serializable]
//public class HiScore
//{
//    public string name;
//    public int score;
//}


//[System.Serializable]
//public class HiScores
//{
//    public HiScore[] scores;
//}


//public class HTTPReadWrite : MonoBehaviour {

//    void Start()
//    {
//        StartCoroutine(GetText());
//    }

//    IEnumerator GetText()
//    {
//        UnityWebRequest www = UnityWebRequest.Get("http://localhost:5000/scores");  // https://doni-server.herokuapp.com/scores
//        yield return www.Send();

//        if (www.isError)
//        {
//            Debug.Log(www.error);
//        }
//        else
//        {
//            // Show results as text
//            Debug.Log(www.downloadHandler.text);
//            HiScores hs = JsonUtility.FromJson<HiScores>(www.downloadHandler.text);

//            Debug.Log(hs.scores.Length);

//            foreach(HiScore h in hs.scores)
//            {
//                Debug.Log("Name: " + h.name);
//                Debug.Log("Score: " + h.score);
//            }

//            // Or retrieve results as binary data
//            byte[] results = www.downloadHandler.data;
//        }
//    }

//    public void PostHighScore()
//    {
//        Debug.Log("HighScore posted!");

//        HiScore hs = new HiScore();
//        hs.name = "Esim1";
//        hs.score = 20;

//        StartCoroutine(POST(hs));


//    }

//    IEnumerator POST(HiScore hs)
//    {
//        Dictionary<string, string> headers = new Dictionary<string, string>();
//        headers.Add("Content-Type", "application/json"); // Key + Value (Postman -> Post -> Headers )

//        string jsonData = JsonUtility.ToJson(hs);
//        byte[] postData = System.Text.Encoding.UTF8.GetBytes(jsonData);

//        WWW www = new WWW("http://localhost:5000/scores",
//                            postData,
//                            headers);

//        yield return www;

//        Debug.Log(www);
//    }
//}
