using System;

using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    static float maxScore = 0;
    float score;
   [SerializeField] TextMeshProUGUI text = null;
    [SerializeField] TextMeshProUGUI highScore = null;



    // Update is called once per frame
    void Update()
    {
       
        score += Time.deltaTime;
        text.text = String.Format("{0:0}", score);
        ShowMaxScore();


    }

    public void SetMaxScore()
    {
        if (maxScore < score)
        {
            maxScore = score;
        }
    }
    void ShowMaxScore()
    {
        highScore.text = "Hightscore: "+ String.Format("{0:0}", maxScore);
    }
}
